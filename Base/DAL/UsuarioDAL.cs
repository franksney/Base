using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=SA;Initial Catalog=loja;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_InserirUsuario";

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar) { Value = _usuario.NomeUsuario });
               
                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                _usuario.Id = Convert.ToInt32 (cmd.ExecuteScalar());

                return _usuario;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor Sql Erro: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
