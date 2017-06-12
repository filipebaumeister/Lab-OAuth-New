using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication1.webservice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoProdutos getProdutosDisponiveis()
        //{
        //    StatusRetornoProdutos retorno = new StatusRetornoProdutos();
        //    try
        //    {
        //        retorno.lstProdutos = Util.WebSession.GetProdutosDisponiveis(Session).lstProdutos;
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetorno AdicionaProduto(int id)
        //{
        //    StatusRetorno retorno = new StatusRetorno(Session);
        //    try
        //    {
        //        Pedido produtosEscolhidos = Util.WebSession.GetPedidoAtual(Session);
        //        Produto prod = Util.WebSession.GetProdutosDisponiveis(Session).GetById(id);
        //        produtosEscolhidos.AdicionaProduto(prod);
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoProdutos getProdutosEscolhidos()
        //{
        //    StatusRetornoProdutos retorno = new StatusRetornoProdutos();
        //    try
        //    {
        //        retorno.id = Util.WebSession.GetPedidoAtual(Session).Id;
        //        retorno.lstProdutos = Util.WebSession.GetPedidoAtual(Session)._Produtos.lstProdutos;
        //        retorno.preco = Util.WebSession.GetPedidoAtual(Session).Preco;
        //        retorno.d_Preco = Util.WebSession.GetPedidoAtual(Session).d_Preco;
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetorno RemoveProdutoPedido(int id)
        //{
        //    StatusRetorno retorno = new StatusRetorno();
        //    try
        //    {
        //        Pedido produtosEscolhidos = Util.WebSession.GetPedidoAtual(Session);
        //        Produto prod = Util.WebSession.GetProdutosDisponiveis(Session).GetById(id);
        //        produtosEscolhidos.RemoveProduto(prod);
        //        //if (!produtosEscolhidos._Produtos.ContemElementos())
        //        //{
        //        //    Util.WebSession.CriaNovoPedido(Session);
        //        //}
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetorno CriarNovoPedido()
        //{
        //    StatusRetorno retorno = new StatusRetorno();
        //    try
        //    {
        //        Util.WebSession.CriaNovoPedido(Session);
        //        Util.WebSession.GetProdutosDisponiveis(Session).ResetarQuantidade();
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoVendas GetVendasSemanais(int semana, string tipo)
        //{
        //    StatusRetornoVendas retorno = new StatusRetornoVendas();
        //    try
        //    {
        //        if (tipo == "W")
        //        {
        //            retorno.vendas = new List<Venda>()
        //        {
        //                new Venda(Constantes.Meses.Jan, 2000),
        //                new Venda(Constantes.Meses.Fev, 2300),
        //                new Venda(Constantes.Meses.Mar, 2200),
        //                new Venda(Constantes.Meses.Abr, 2100),
        //                new Venda(Constantes.Meses.Mai, 2100),
        //        };
        //        }
        //        else if (tipo == "C")
        //        {
        //            retorno.vendas = new List<Venda>()
        //        {
        //                new Venda(Constantes.Meses.Jan, 2500),
        //                new Venda(Constantes.Meses.Fev, 2800),
        //                new Venda(Constantes.Meses.Mar, 2900),
        //                new Venda(Constantes.Meses.Abr, 2200),
        //                new Venda(Constantes.Meses.Mai, 2100),
        //        };
        //        }
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public UserInfo getInfos(int id)
        //{
        //    UserInfo retorno = new UserInfo();
        //    retorno.id = id;
        //    try
        //    {
        //        if (id == 1)
        //        {
        //            retorno.id = 1;
        //            retorno.semester = 3;
        //            retorno.cpf = "01869535693";
        //            retorno.birthday = "1992-09-03";
        //            retorno.email = "filipebaumeister@hotmail.com";
        //            retorno.user = "Filipe";
        //            retorno.password = "FudgeYourHamster";
        //            retorno.valor = 15000;//.ToString("R$ 0,0.00");
        //            //retorno.valor = 15000.ToString("R$ 0,0.00");
        //            retorno.idCarro = 1;
        //        }
        //        else if (id == 2)
        //        {
        //            retorno.id = 2;
        //            retorno.semester = 7;
        //            retorno.cpf = "01869535693";
        //            retorno.birthday = "1993-10-24";
        //            retorno.email = "tael@hotmail.com";
        //            retorno.user = "Tael";
        //            retorno.password = "FudgeYour";
        //            retorno.valor = 11589.95;
        //            //retorno.valor = 11589.95.ToString("R$ 0,0.00");
        //            retorno.idCarro = 5;
        //        }
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //public static List<Carro> carros = new List<Carro>() {
        //            new Carro(1, "Polo"),
        //            new Carro(2, "Fox"),
        //            new Carro(3, "Golf"),
        //            new Carro(4, "HB 20"),
        //            new Carro(5, "Sandero"),
        //};

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoCarros getCarros()
        //{
        //    StatusRetornoCarros retorno = new StatusRetornoCarros();
        //    try
        //    {
        //        retorno.lstCarros = carros;
        //        System.Threading.Thread.Sleep(1500);
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoCarro addCarro(string nomeCarro)
        //{
        //    StatusRetornoCarro retorno = new StatusRetornoCarro();
        //    try
        //    {
        //        int id = carros.Count;
        //        Carro carro = new Carro(++id, nomeCarro);
        //        carros.Add(carro);

        //        retorno.carro = carro;
        //        retorno.sucesso = true;
        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public StatusRetornoNeedAdminRights testeAdminLogado()
        //{
        //    var retorno = new StatusRetornoNeedAdminRights();
        //    try
        //    {
        //        throw new UserNotLoggedException();

        //        if (!retorno.hasAdminRights)
        //            return retorno;

        //        return retorno;
        //    }
        //    catch (UserNotLoggedException ex)
        //    {
        //        return new StatusRetornoNeedAdminRights(ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        retorno.sucesso = false;
        //        retorno.mensagem = ex.Message;
        //        return retorno;
        //    }
        //}

        //[WebMethod(EnableSession = true)]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public void alterarPessoa(UserInfo user)
        //{

        //}

        string connectionString = "Server=tcp:filipebaumeister.database.windows.net,1433;Initial Catalog=MeuBD;Persist Security Info=False;User ID=filipebaumeister;Password=Ldmids13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public StatusRetornoEducation addEducation(string nomeInstituicao, string inicio, string tipoEnsino)
        {
            StatusRetornoEducation statusRetorno = new StatusRetornoEducation();
            try
            {
                DateTime dataInicio;
                bool success = DateTime.TryParse(inicio, out dataInicio);
                if (!success)
                {
                    dataInicio = new DateTime(Convert.ToInt16(inicio), 1, 1);
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO EDUCACAO (NOME, INICIO, TIPO) VALUES ('" + nomeInstituicao
                    + "', '" + dataInicio.ToString("yyyy-MM-dd") + "', '" + tipoEnsino + "')" +
                    "SELECT SCOPE_IDENTITY() AS ID;"
                    , conn))
                {
                    SqlParameter outputIdParam = new SqlParameter("ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(outputIdParam);

                    conn.Open();
                    var id = cmd.ExecuteScalar();

                    statusRetorno.sucesso = true;
                    statusRetorno.id = Convert.ToInt16(id);
                    statusRetorno.nomeInstituicao = nomeInstituicao;
                    statusRetorno.inicio = dataInicio;
                    statusRetorno.strDtInicio = dataInicio.ToString("yyyy-MM-dd");
                    statusRetorno.tipoEnsino = tipoEnsino;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                statusRetorno.sucesso = false;
                statusRetorno.mensagem = ex.Message;
            }
            return statusRetorno;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void changeEducation()
        {

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public StatusRetornoUsuario CheckIfUserExists(string id, string nome, List<Ensino> lstEducations)
        {
            StatusRetornoUsuario statusRetorno = new StatusRetornoUsuario();
            try
            {
                string sqlCommand = String.Format("SELECT * FROM USUARIO WHERE ID_FACEBOOK = '{0}';", id);
                DataSet ds = DB.GetDataSet(connectionString, sqlCommand);
                bool usuarioExistente = ds.Tables[0].Rows.Count > 0;
                if (usuarioExistente)
                {
                    statusRetorno.userExisting = true;
                    statusRetorno.lstEducations = GetEnsinos(id).lstEducations;
                    statusRetorno.sucesso = true;
                    return statusRetorno;
                }

                sqlCommand = String.Format("INSERT INTO USUARIO (NOME, IS_ADMIN, ID_FACEBOOK) VALUES ('{0}',0,'{1}');SELECT SCOPE_IDENTITY() AS ID;", nome, id);
                ds = DB.GetDataSet(connectionString, sqlCommand);

                foreach (Ensino ensino in lstEducations)
                {
                    sqlCommand = String.Format("INSERT INTO EDUCACAO (NOME, INICIO, TIPO, ID_USUARIO) VALUES ('{0}','{1}','{2}',{3})", ensino.nomeInstituicao, ensino.inicio, ensino.tipoEnsino, id);
                    ds = DB.GetDataSet(connectionString, sqlCommand);
                }

                statusRetorno.lstEducations = lstEducations;
                statusRetorno.sucesso = true;
                return statusRetorno;
            }
            catch (Exception ex)
            {
                statusRetorno.sucesso = false;
                statusRetorno.mensagem = ex.Message;
                return statusRetorno;
            }
        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public StatusRetornoUsuario GetEnsinos(string id)
        {
            StatusRetornoUsuario statusRetorno = new StatusRetornoUsuario();

            string sqlCommand = String.Format("SELECT * FROM EDUCACAO WHERE ID_USUARIO = '{0}';", id);
            DataSet ds = DB.GetDataSet(connectionString, sqlCommand);

            statusRetorno.lstEducations = new List<Ensino>();
            foreach (DataRow ensinoRow in ds.Tables[0].Rows)
            {
                Ensino ensino = new Ensino();
                ensino.id = ensinoRow["ID"].ToString();
                ensino.nomeInstituicao = ensinoRow["NOME"].ToString();
                ensino.tipoEnsino = ensinoRow["TIPO"].ToString();
                ensino.inicio = ensinoRow["INICIO"].ToString();
                ensino.fim = ensinoRow["FIM"] == null ? null : ensinoRow["FIM"].ToString();
                statusRetorno.lstEducations.Add(ensino);
            }

            statusRetorno.sucesso = true;
            return statusRetorno;
        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public StatusRetornoUsuario AlterarEnsino(int id, string nome, string tipo, string inicio, string fim)
        {
            StatusRetornoUsuario statusRetorno = new StatusRetornoUsuario();
            string sqlCommand = String.Format("UPDATE EDUCACAO SET [NOME] = '{0}', [INICIO] = '{1}', [FIM] = '{2}', [TIPO] = '{3}' WHERE ID = {4};", 
                nome, inicio, fim, tipo, id);

            DB.GetDataSet(connectionString, sqlCommand);

            statusRetorno.sucesso = true;
            return statusRetorno;
        }
    }
}
