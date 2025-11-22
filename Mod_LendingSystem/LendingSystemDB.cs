using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_LendingSystem
{
    internal class LendingSystemDB
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LendingSystem;Integrated Security=True;";

        public int ExecuteNonQuery(string commandText, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error (NonQuery): {ex.Message}");
                throw;
            }
        }

        public DataTable ExecuteQuery(string commandText, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error (Query): {ex.Message}");
                throw;
            }

            return dt;
        }

        public object ExecuteScalar(string commandText, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error (Scalar): {ex.Message}");
                throw;
            }
        }

        public int AddCustomer(string username, string passwordHash, string firstName, string lastName, string contactNo, string middleInitial = null)
        {
            string sql = @"
                INSERT INTO CUSTOMERS (username, password_hash, first_name, last_name, middle_initial, contact_no)
                OUTPUT INSERTED.customer_id
                VALUES (@Username, @PasswordHash, @FirstName, @LastName, @MiddleInitial, @ContactNo);";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@MiddleInitial", string.IsNullOrEmpty(middleInitial) ? (object)DBNull.Value : middleInitial),
                new SqlParameter("@ContactNo", string.IsNullOrEmpty(contactNo) ? (object)DBNull.Value : contactNo)
            };

            return ExecuteNonQuery(sql, parameters);
        }

        public DataTable Login(string username, string passwordHash)
        {
            string sql = @"
                SELECT customer_id, first_name, last_name, middle_initial, contact_no 
                FROM CUSTOMERS 
                WHERE username = @Username AND password_hash = @PasswordHash";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash)
            };

            return ExecuteQuery(sql, parameters);
        }

        public DataTable GetActiveLoanDetails(int customerId)
        {
            string sql = @"
                SELECT loan_id, principal_amount, total_interest, current_balance, due_date
                FROM LOANS
                WHERE customer_id = @CustomerId AND status = 'Active'";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerId", customerId)
            };

            return ExecuteQuery(sql, parameters);
        }

        public bool RecordPaymentAndUpdateLoan(int loanId, int customerId, decimal amountPaid, decimal principalPaid, decimal interestPaid, string notes = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string insertSql = @"
                        INSERT INTO TRANSACTIONS (loan_id, customer_id, transaction_type, amount, principal_paid, interest_paid, notes)
                        VALUES (@LoanId, @CustomerId, 'Payment', @Amount, @PrincipalPaid, @InterestPaid, @Notes);";

                    SqlParameter[] insertParams =
                    {
                        new SqlParameter("@LoanId", loanId),
                        new SqlParameter("@CustomerId", customerId),
                        new SqlParameter("@Amount", amountPaid),
                        new SqlParameter("@PrincipalPaid", principalPaid),
                        new SqlParameter("@InterestPaid", interestPaid),
                        new SqlParameter("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes)
                    };

                    using (SqlCommand insertCommand = new SqlCommand(insertSql, connection, transaction))
                    {
                        insertCommand.Parameters.AddRange(insertParams);
                        insertCommand.ExecuteNonQuery();
                    }

                    string updateSql = @"
                        UPDATE LOANS 
                        SET current_balance = current_balance - @AmountPaid,
                            status = CASE WHEN current_balance - @AmountPaid <= 0 THEN 'Paid' ELSE status END
                        WHERE loan_id = @LoanId;";

                    SqlParameter[] updateParams =
                    {
                        new SqlParameter("@AmountPaid", amountPaid),
                        new SqlParameter("@LoanId", loanId)
                    };

                    using (var updateCommand = new SqlCommand(updateSql, connection, transaction))
                    {
                        updateCommand.Parameters.AddRange(updateParams);
                        updateCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"Payment/Loan Update Error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}