using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTbProfissional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbAlimento",
                columns: table => new
                {
                    IdAlimento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoQuantidade = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Carboidrato = table.Column<double>(type: "float", nullable: false),
                    VitaminaA = table.Column<double>(type: "float", nullable: false),
                    VitaminaB = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAlimento", x => x.IdAlimento);
                });

            migrationBuilder.CreateTable(
                name: "tbEscalaBristol",
                columns: table => new
                {
                    IdEscalaBristol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sangue = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEscalaBristol", x => x.IdEscalaBristol);
                });

            migrationBuilder.CreateTable(
                name: "tbExame",
                columns: table => new
                {
                    IdExame = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grupo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbExame", x => x.IdExame);
                });

            migrationBuilder.CreateTable(
                name: "tbGrupoPatologico",
                columns: table => new
                {
                    IdGrupoPatologico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGrupoPatologico", x => x.IdGrupoPatologico);
                });

            migrationBuilder.CreateTable(
                name: "tbPais",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sigla = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "tbPatologia",
                columns: table => new
                {
                    IdPatologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    InformacaoComplementar = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPatologia", x => x.IdPatologia);
                });

            migrationBuilder.CreateTable(
                name: "tbPlano",
                columns: table => new
                {
                    IdPlano = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Validade = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPlano", x => x.IdPlano);
                });

            migrationBuilder.CreateTable(
                name: "tbTipoAcesso",
                columns: table => new
                {
                    IdTipoAcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTipoAcesso", x => x.IdTipoAcesso);
                });

            migrationBuilder.CreateTable(
                name: "tbEstado",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPais = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEstado", x => x.IdEstado);
                    table.ForeignKey(
                        name: "FK_tbEstado_tbPais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "tbPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbGrupoPatologico_X_Patologia",
                columns: table => new
                {
                    IdPatologia_X_GrupoPatologico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGrupoPatologico = table.Column<int>(type: "int", nullable: false),
                    IdPatologia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGrupoPatologico_X_Patologia", x => x.IdPatologia_X_GrupoPatologico);
                    table.ForeignKey(
                        name: "FK_tbGrupoPatologico_X_Patologia_tbGrupoPatologico_IdGrupoPatologico",
                        column: x => x.IdGrupoPatologico,
                        principalTable: "tbGrupoPatologico",
                        principalColumn: "IdGrupoPatologico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbGrupoPatologico_X_Patologia_tbPatologia_IdPatologia",
                        column: x => x.IdPatologia,
                        principalTable: "tbPatologia",
                        principalColumn: "IdPatologia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbContrato",
                columns: table => new
                {
                    IdContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlano = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    DataFim = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbContrato", x => x.IdContrato);
                    table.ForeignKey(
                        name: "FK_tbContrato_tbPlano_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "tbPlano",
                        principalColumn: "IdPlano",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbCidade",
                columns: table => new
                {
                    IdCidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEstado = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCidade", x => x.IdCidade);
                    table.ForeignKey(
                        name: "FK_tbCidade_tbEstado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "tbEstado",
                        principalColumn: "IdEstado");
                });

            migrationBuilder.CreateTable(
                name: "tbPaciente",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CPF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    NomeResponsavel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sexo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Etnia = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCidade = table.Column<int>(type: "int", nullable: true),
                    TelResidencial = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TelComercial = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    TelCelular = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Profissao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FlgAtleta = table.Column<bool>(type: "bit", nullable: true),
                    FlgGestante = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPaciente", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_tbPaciente_tbCidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "tbCidade",
                        principalColumn: "IdCidade");
                });

            migrationBuilder.CreateTable(
                name: "tbProfissional",
                columns: table => new
                {
                    IdProfissional = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoProfissional = table.Column<int>(type: "int", nullable: true),
                    IdContrato = table.Column<int>(type: "int", nullable: false),
                    IdTipoAcesso = table.Column<int>(type: "int", nullable: true),
                    IdCidade = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CRM_CRN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Especialidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Numero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CEP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD1 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD2 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Telefone1 = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Telefone2 = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProfissional", x => x.IdProfissional);
                    table.ForeignKey(
                        name: "FK_tbProfissional_tbCidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "tbCidade",
                        principalColumn: "IdCidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbProfissional_tbContrato_IdContrato",
                        column: x => x.IdContrato,
                        principalTable: "tbContrato",
                        principalColumn: "IdContrato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbProfissional_tbTipoAcesso_IdTipoAcesso",
                        column: x => x.IdTipoAcesso,
                        principalTable: "tbTipoAcesso",
                        principalColumn: "IdTipoAcesso");
                });

            migrationBuilder.CreateTable(
                name: "tbExame_X_Pacientes",
                columns: table => new
                {
                    IdExame_X_Paciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdExame = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateOnly>(type: "date", nullable: true),
                    Resultado = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbExame_X_Pacientes", x => x.IdExame_X_Paciente);
                    table.ForeignKey(
                        name: "FK_tbExame_X_Pacientes_tbExame_IdExame",
                        column: x => x.IdExame,
                        principalTable: "tbExame",
                        principalColumn: "IdExame",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbExame_X_Pacientes_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbHistoriaPatologica",
                columns: table => new
                {
                    IdHistoriaPatologica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdPatologia = table.Column<int>(type: "int", nullable: true),
                    FlgHAS = table.Column<bool>(type: "bit", nullable: true),
                    FlgAVC = table.Column<bool>(type: "bit", nullable: true),
                    FlgDoencasPulmonares = table.Column<bool>(type: "bit", nullable: true),
                    FlgDoencasCardiacas = table.Column<bool>(type: "bit", nullable: true),
                    FlgDoencaRenal = table.Column<bool>(type: "bit", nullable: true),
                    FlgDoencaHepatica = table.Column<bool>(type: "bit", nullable: true),
                    FlgNeoplasia = table.Column<bool>(type: "bit", nullable: true),
                    FlgHipercolesterolemia = table.Column<bool>(type: "bit", nullable: true),
                    FlgHipertrigliciridemia = table.Column<bool>(type: "bit", nullable: true),
                    FlgHiperuricemia = table.Column<bool>(type: "bit", nullable: true),
                    FlgAnemias = table.Column<bool>(type: "bit", nullable: true),
                    FlgCirurgias = table.Column<bool>(type: "bit", nullable: true),
                    FlgDoencasAutoImunes = table.Column<bool>(type: "bit", nullable: true),
                    FlgDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    Obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHistoriaPatologica", x => x.IdHistoriaPatologica);
                    table.ForeignKey(
                        name: "FK_tbHistoriaPatologica_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbHistoriaPatologica_tbPatologia_IdPatologia",
                        column: x => x.IdPatologia,
                        principalTable: "tbPatologia",
                        principalColumn: "IdPatologia");
                });

            migrationBuilder.CreateTable(
                name: "tbHistoricoAlimentarNutricional",
                columns: table => new
                {
                    IdHistAlimentarNutricional = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    MotivacaoTratamento = table.Column<int>(type: "int", nullable: true),
                    ModismosAlimentares = table.Column<int>(type: "int", nullable: true),
                    FlgIntoleanciaAlimentar = table.Column<bool>(type: "bit", nullable: true),
                    DescIntoleranciaAlimentar = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FaseObesidadePerdaPeso = table.Column<int>(type: "int", nullable: true),
                    FlgPerdaGanhoPeso = table.Column<bool>(type: "bit", nullable: true),
                    PesoMax = table.Column<int>(type: "int", nullable: true),
                    PesoMaxIdade = table.Column<int>(type: "int", nullable: true),
                    PesoMin = table.Column<int>(type: "int", nullable: true),
                    PesoMinIdade = table.Column<int>(type: "int", nullable: true),
                    FlgDietas = table.Column<bool>(type: "bit", nullable: true),
                    DescDietas = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FlgMedicamentos = table.Column<bool>(type: "bit", nullable: true),
                    DescMedicamentos = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FlgExercicios = table.Column<bool>(type: "bit", nullable: true),
                    DescExercicios = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FlgOutros = table.Column<bool>(type: "bit", nullable: true),
                    DescOutros = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHistoricoAlimentarNutricional", x => x.IdHistAlimentarNutricional);
                    table.ForeignKey(
                        name: "FK_tbHistoricoAlimentarNutricional_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbHistoricoDoencaAtual",
                columns: table => new
                {
                    IdHDA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdPatologia = table.Column<int>(type: "int", nullable: true),
                    Historico = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Cirurgia = table.Column<int>(type: "int", nullable: true),
                    Trauma = table.Column<int>(type: "int", nullable: true),
                    Infeccao = table.Column<int>(type: "int", nullable: true),
                    Neoplasia = table.Column<int>(type: "int", nullable: true),
                    Metastase = table.Column<int>(type: "int", nullable: true),
                    Queimadura = table.Column<int>(type: "int", nullable: true),
                    ObsNeoplasia = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ObsMetastase = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ObsQueimadura = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Outros = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHistoricoDoencaAtual", x => x.IdHDA);
                    table.ForeignKey(
                        name: "FK_tbHistoricoDoencaAtual_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbHistoricoDoencaAtual_tbPatologia_IdPatologia",
                        column: x => x.IdPatologia,
                        principalTable: "tbPatologia",
                        principalColumn: "IdPatologia");
                });

            migrationBuilder.CreateTable(
                name: "tbHistoricoSocialAlimentar",
                columns: table => new
                {
                    IdHistSocialAlimentar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Profissao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CargaHoraria = table.Column<int>(type: "int", nullable: true),
                    NroPessoasRes = table.Column<int>(type: "int", nullable: true),
                    RendaFamiliar = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Escolaridade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NomeCompraAlimento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NomeCozinhaAlimento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CompraFeita = table.Column<int>(type: "int", nullable: true),
                    NomeRealizaRefeicao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FlgTabagismo = table.Column<bool>(type: "bit", nullable: true),
                    QtdTabagismoDia = table.Column<int>(type: "int", nullable: true),
                    FlgEtilismo = table.Column<bool>(type: "bit", nullable: true),
                    QtdEtilismoDia = table.Column<int>(type: "int", nullable: true),
                    FlgCafe = table.Column<bool>(type: "bit", nullable: true),
                    QtdCafeDia = table.Column<int>(type: "int", nullable: true),
                    FlgPaiMaeHas = table.Column<bool>(type: "bit", nullable: true),
                    FlgAvosHas = table.Column<bool>(type: "bit", nullable: true),
                    FlgIrmaosHas = table.Column<bool>(type: "bit", nullable: true),
                    FlgPaiMaeDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    FlgAvosDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    FlgIrmaosDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    FlgPaiMaeCancer = table.Column<bool>(type: "bit", nullable: true),
                    FlgAvosCancer = table.Column<bool>(type: "bit", nullable: true),
                    FlgIrmaosCancer = table.Column<bool>(type: "bit", nullable: true),
                    FlgPaiMaeObesidade = table.Column<bool>(type: "bit", nullable: true),
                    FlgAvosObesidade = table.Column<bool>(type: "bit", nullable: true),
                    FlgIrmaosObesidade = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHistoricoSocialAlimentar", x => x.IdHistSocialAlimentar);
                    table.ForeignKey(
                        name: "FK_tbHistoricoSocialAlimentar_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbHoraPaciente_Profissional",
                columns: table => new
                {
                    IdHoraPaciente_Profissional = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdProfissional = table.Column<int>(type: "int", nullable: false),
                    DataConsulta = table.Column<DateOnly>(type: "date", nullable: true),
                    HoraInicioIndividual = table.Column<TimeOnly>(type: "time(0)", precision: 0, nullable: false),
                    HoraFimIndividual = table.Column<TimeOnly>(type: "time(0)", precision: 0, nullable: false),
                    PrimeiraConculta = table.Column<bool>(type: "bit", nullable: false),
                    Compareceu = table.Column<bool>(type: "bit", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Resumo = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHoraPaciente_Profissional", x => x.IdHoraPaciente_Profissional);
                    table.ForeignKey(
                        name: "FK_tbHoraPaciente_Profissional_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbHoraPaciente_Profissional_tbProfissional_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "tbProfissional",
                        principalColumn: "IdProfissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMedico_Paciente",
                columns: table => new
                {
                    IdMedico_Paciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdProfissional = table.Column<int>(type: "int", nullable: false),
                    InformacaoResumida = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMedico_Paciente", x => x.IdMedico_Paciente);
                    table.ForeignKey(
                        name: "FK_tbMedico_Paciente_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbMedico_Paciente_tbProfissional_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "tbProfissional",
                        principalColumn: "IdProfissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPergunta",
                columns: table => new
                {
                    IdPergunta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfissional = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPergunta", x => x.IdPergunta);
                    table.ForeignKey(
                        name: "FK_tbPergunta_tbProfissional_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "tbProfissional",
                        principalColumn: "IdProfissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbReceitaAlimentarPadrao",
                columns: table => new
                {
                    IdReceitaAlimentarPadrao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfissional = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    InformacaoComplementar = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbReceitaAlimentarPadrao", x => x.IdReceitaAlimentarPadrao);
                    table.ForeignKey(
                        name: "FK_tbReceitaAlimentarPadrao_tbProfissional_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "tbProfissional",
                        principalColumn: "IdProfissional");
                });

            migrationBuilder.CreateTable(
                name: "tbReceitaMedicaPadrao",
                columns: table => new
                {
                    IdReceitaMedicaPadrao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfissional = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    InformacaoComplementar = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbReceitaMedicaPadrao", x => x.IdReceitaMedicaPadrao);
                    table.ForeignKey(
                        name: "FK_tbReceitaMedicaPadrao_tbProfissional_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "tbProfissional",
                        principalColumn: "IdProfissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbAntropometria",
                columns: table => new
                {
                    IdAntropometria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoraPaciente_Profissional = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: true),
                    AlturaJoelho = table.Column<int>(type: "int", nullable: true),
                    PesoAtual = table.Column<int>(type: "int", nullable: true),
                    PesoUsual = table.Column<int>(type: "int", nullable: true),
                    TipoProtocolo = table.Column<int>(type: "int", nullable: true),
                    Tricipal = table.Column<int>(type: "int", nullable: true),
                    Subescap = table.Column<int>(type: "int", nullable: true),
                    AuxiliarMed = table.Column<int>(type: "int", nullable: true),
                    SupraIliaca = table.Column<int>(type: "int", nullable: true),
                    Abdomen = table.Column<int>(type: "int", nullable: true),
                    Peitoral = table.Column<int>(type: "int", nullable: true),
                    Coxa = table.Column<int>(type: "int", nullable: true),
                    Biceps = table.Column<int>(type: "int", nullable: true),
                    Panturrilha = table.Column<int>(type: "int", nullable: true),
                    PercGordura = table.Column<int>(type: "int", nullable: true),
                    CircunfBraco = table.Column<int>(type: "int", nullable: true),
                    CircunfAbdomen = table.Column<int>(type: "int", nullable: true),
                    CircunfCintura = table.Column<int>(type: "int", nullable: true),
                    CircunfQuadril = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAntropometria", x => x.IdAntropometria);
                    table.ForeignKey(
                        name: "FK_tbAntropometria_tbHoraPaciente_Profissional_IdHoraPaciente_Profissional",
                        column: x => x.IdHoraPaciente_Profissional,
                        principalTable: "tbHoraPaciente_Profissional",
                        principalColumn: "IdHoraPaciente_Profissional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbAntropometria_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEscalaBristol_Paciente_Consulta",
                columns: table => new
                {
                    IdEscalaBristol_Paciente_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEscalaBristol = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdHora_Paciente_Profissional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEscalaBristol_Paciente_Consulta", x => x.IdEscalaBristol_Paciente_Consulta);
                    table.ForeignKey(
                        name: "FK_tbEscalaBristol_Paciente_Consulta_tbEscalaBristol_IdEscalaBristol",
                        column: x => x.IdEscalaBristol,
                        principalTable: "tbEscalaBristol",
                        principalColumn: "IdEscalaBristol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbEscalaBristol_Paciente_Consulta_tbHoraPaciente_Profissional_IdHora_Paciente_Profissional",
                        column: x => x.IdHora_Paciente_Profissional,
                        principalTable: "tbHoraPaciente_Profissional",
                        principalColumn: "IdHoraPaciente_Profissional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbEscalaBristol_Paciente_Consulta_tbPaciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "tbPaciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbExameFisico",
                columns: table => new
                {
                    IdExameFisico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoraPaciente_Profissional = table.Column<int>(type: "int", nullable: true),
                    SNC = table.Column<int>(type: "int", nullable: true),
                    AtividadeFisica = table.Column<int>(type: "int", nullable: true),
                    TipoAtividadeFisica = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Frequencia = table.Column<int>(type: "int", nullable: true),
                    HoraPreferido = table.Column<int>(type: "int", nullable: true),
                    Tempo = table.Column<int>(type: "int", nullable: true),
                    FlgDenticaoCompleta = table.Column<bool>(type: "bit", nullable: true),
                    FlgDenticaoIncompleta = table.Column<bool>(type: "bit", nullable: true),
                    FlgDenticaoAusente = table.Column<bool>(type: "bit", nullable: true),
                    FlgDenticaoProtese = table.Column<bool>(type: "bit", nullable: true),
                    Mastigacao = table.Column<int>(type: "int", nullable: true),
                    Peristalse = table.Column<int>(type: "int", nullable: true),
                    Fumante = table.Column<int>(type: "int", nullable: true),
                    FrequenciaCardiaca = table.Column<int>(type: "int", nullable: true),
                    PA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FrequenciaRespiratoria = table.Column<int>(type: "int", nullable: true),
                    Temperatura = table.Column<int>(type: "int", nullable: true),
                    Glicemia = table.Column<int>(type: "int", nullable: true),
                    Diurese = table.Column<int>(type: "int", nullable: true),
                    TipoDiurese = table.Column<int>(type: "int", nullable: true),
                    Evacuacao = table.Column<int>(type: "int", nullable: true),
                    TipoEvacuacao = table.Column<int>(type: "int", nullable: true),
                    Ingestao = table.Column<int>(type: "int", nullable: true),
                    Excrecao = table.Column<int>(type: "int", nullable: true),
                    FlgXerostomia = table.Column<bool>(type: "bit", nullable: true),
                    FlgSialorreia = table.Column<bool>(type: "bit", nullable: true),
                    FlgUlcerasBucais = table.Column<bool>(type: "bit", nullable: true),
                    FlgNauseas = table.Column<bool>(type: "bit", nullable: true),
                    FlgVomitos = table.Column<bool>(type: "bit", nullable: true),
                    FlgDisfagia = table.Column<bool>(type: "bit", nullable: true),
                    FlgOdinofagia = table.Column<bool>(type: "bit", nullable: true),
                    FlgFistula = table.Column<bool>(type: "bit", nullable: true),
                    FlgOral = table.Column<bool>(type: "bit", nullable: true),
                    FlgOralEnteral = table.Column<bool>(type: "bit", nullable: true),
                    FlgEnteralExclusiva = table.Column<bool>(type: "bit", nullable: true),
                    FlgEnteralParental = table.Column<bool>(type: "bit", nullable: true),
                    FlgParentalExclusiva = table.Column<bool>(type: "bit", nullable: true),
                    FlgParentalOral = table.Column<bool>(type: "bit", nullable: true),
                    TipoAcesso = table.Column<int>(type: "int", nullable: true),
                    FlgGastrico = table.Column<bool>(type: "bit", nullable: true),
                    FlgTranspilorica = table.Column<bool>(type: "bit", nullable: true),
                    FlgDuodenal = table.Column<bool>(type: "bit", nullable: true),
                    FlgJejunal = table.Column<bool>(type: "bit", nullable: true),
                    FlgHiperemia = table.Column<bool>(type: "bit", nullable: true),
                    FlgSaidaSecrecao = table.Column<bool>(type: "bit", nullable: true),
                    FlgPresencaFeridas = table.Column<bool>(type: "bit", nullable: true),
                    Obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbExameFisico", x => x.IdExameFisico);
                    table.ForeignKey(
                        name: "FK_tbExameFisico_tbHoraPaciente_Profissional_IdHoraPaciente_Profissional",
                        column: x => x.IdHoraPaciente_Profissional,
                        principalTable: "tbHoraPaciente_Profissional",
                        principalColumn: "IdHoraPaciente_Profissional");
                });

            migrationBuilder.CreateTable(
                name: "tbRastreamentoResposta",
                columns: table => new
                {
                    IdRastreamentoResposta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPergunta = table.Column<int>(type: "int", nullable: false),
                    VlrRespota = table.Column<int>(type: "int", nullable: false),
                    IdParteCorpo = table.Column<int>(type: "int", nullable: false),
                    Obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRastreamentoResposta", x => x.IdRastreamentoResposta);
                    table.ForeignKey(
                        name: "FK_tbRastreamentoResposta_tbPergunta_IdPergunta",
                        column: x => x.IdPergunta,
                        principalTable: "tbPergunta",
                        principalColumn: "IdPergunta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbReceitaAlimentarPadrao_X_Alimento",
                columns: table => new
                {
                    IdReceitaAlimentarPadrao_X_Alimento_X_QuantidadeAlimento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReceitaAlimentarPadrao = table.Column<int>(type: "int", nullable: false),
                    IdAlimento = table.Column<int>(type: "int", nullable: false),
                    IdQuantidadeAlimento = table.Column<int>(type: "int", nullable: false),
                    Periodicidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    QuantoTempo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbReceitaAlimentarPadrao_X_Alimento", x => x.IdReceitaAlimentarPadrao_X_Alimento_X_QuantidadeAlimento);
                    table.ForeignKey(
                        name: "FK_tbReceitaAlimentarPadrao_X_Alimento_tbAlimento_IdAlimento",
                        column: x => x.IdAlimento,
                        principalTable: "tbAlimento",
                        principalColumn: "IdAlimento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbReceitaAlimentarPadrao_X_Alimento_tbReceitaAlimentarPadrao_IdReceitaAlimentarPadrao",
                        column: x => x.IdReceitaAlimentarPadrao,
                        principalTable: "tbReceitaAlimentarPadrao",
                        principalColumn: "IdReceitaAlimentarPadrao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbRastreamentoMetabolico",
                columns: table => new
                {
                    IdRastreamentoMetabolico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRastreamentoResposta = table.Column<int>(type: "int", nullable: false),
                    IdHoraPaciente_Profissional = table.Column<int>(type: "int", nullable: false),
                    ObsGeral = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRastreamentoMetabolico", x => x.IdRastreamentoMetabolico);
                    table.ForeignKey(
                        name: "FK_tbRastreamentoMetabolico_tbHoraPaciente_Profissional_IdHoraPaciente_Profissional",
                        column: x => x.IdHoraPaciente_Profissional,
                        principalTable: "tbHoraPaciente_Profissional",
                        principalColumn: "IdHoraPaciente_Profissional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbRastreamentoMetabolico_tbRastreamentoResposta_IdRastreamentoResposta",
                        column: x => x.IdRastreamentoResposta,
                        principalTable: "tbRastreamentoResposta",
                        principalColumn: "IdRastreamentoResposta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbAntropometria_IdHoraPaciente_Profissional",
                table: "tbAntropometria",
                column: "IdHoraPaciente_Profissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbAntropometria_IdPaciente",
                table: "tbAntropometria",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbCidade_IdEstado",
                table: "tbCidade",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tbContrato_IdPlano",
                table: "tbContrato",
                column: "IdPlano");

            migrationBuilder.CreateIndex(
                name: "IX_tbEscalaBristol_Paciente_Consulta_IdEscalaBristol",
                table: "tbEscalaBristol_Paciente_Consulta",
                column: "IdEscalaBristol");

            migrationBuilder.CreateIndex(
                name: "IX_tbEscalaBristol_Paciente_Consulta_IdHora_Paciente_Profissional",
                table: "tbEscalaBristol_Paciente_Consulta",
                column: "IdHora_Paciente_Profissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbEscalaBristol_Paciente_Consulta_IdPaciente",
                table: "tbEscalaBristol_Paciente_Consulta",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbEstado_IdPais",
                table: "tbEstado",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_tbExame_X_Pacientes_IdExame",
                table: "tbExame_X_Pacientes",
                column: "IdExame");

            migrationBuilder.CreateIndex(
                name: "IX_tbExame_X_Pacientes_IdPaciente",
                table: "tbExame_X_Pacientes",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbExameFisico_IdHoraPaciente_Profissional",
                table: "tbExameFisico",
                column: "IdHoraPaciente_Profissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbGrupoPatologico_X_Patologia_IdGrupoPatologico",
                table: "tbGrupoPatologico_X_Patologia",
                column: "IdGrupoPatologico");

            migrationBuilder.CreateIndex(
                name: "IX_tbGrupoPatologico_X_Patologia_IdPatologia",
                table: "tbGrupoPatologico_X_Patologia",
                column: "IdPatologia");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoriaPatologica_IdPaciente",
                table: "tbHistoriaPatologica",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoriaPatologica_IdPatologia",
                table: "tbHistoriaPatologica",
                column: "IdPatologia");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoricoAlimentarNutricional_IdPaciente",
                table: "tbHistoricoAlimentarNutricional",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoricoDoencaAtual_IdPaciente",
                table: "tbHistoricoDoencaAtual",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoricoDoencaAtual_IdPatologia",
                table: "tbHistoricoDoencaAtual",
                column: "IdPatologia");

            migrationBuilder.CreateIndex(
                name: "IX_tbHistoricoSocialAlimentar_IdPaciente",
                table: "tbHistoricoSocialAlimentar",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoraPaciente_Profissional_IdPaciente",
                table: "tbHoraPaciente_Profissional",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoraPaciente_Profissional_IdProfissional",
                table: "tbHoraPaciente_Profissional",
                column: "IdProfissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbMedico_Paciente_IdPaciente",
                table: "tbMedico_Paciente",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbMedico_Paciente_IdProfissional",
                table: "tbMedico_Paciente",
                column: "IdProfissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbPaciente_IdCidade",
                table: "tbPaciente",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_tbPergunta_IdProfissional",
                table: "tbPergunta",
                column: "IdProfissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbProfissional_IdCidade",
                table: "tbProfissional",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_tbProfissional_IdContrato",
                table: "tbProfissional",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_tbProfissional_IdTipoAcesso",
                table: "tbProfissional",
                column: "IdTipoAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_tbRastreamentoMetabolico_IdHoraPaciente_Profissional",
                table: "tbRastreamentoMetabolico",
                column: "IdHoraPaciente_Profissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbRastreamentoMetabolico_IdRastreamentoResposta",
                table: "tbRastreamentoMetabolico",
                column: "IdRastreamentoResposta");

            migrationBuilder.CreateIndex(
                name: "IX_tbRastreamentoResposta_IdPergunta",
                table: "tbRastreamentoResposta",
                column: "IdPergunta");

            migrationBuilder.CreateIndex(
                name: "IX_tbReceitaAlimentarPadrao_IdProfissional",
                table: "tbReceitaAlimentarPadrao",
                column: "IdProfissional");

            migrationBuilder.CreateIndex(
                name: "IX_tbReceitaAlimentarPadrao_X_Alimento_IdAlimento",
                table: "tbReceitaAlimentarPadrao_X_Alimento",
                column: "IdAlimento");

            migrationBuilder.CreateIndex(
                name: "IX_tbReceitaAlimentarPadrao_X_Alimento_IdReceitaAlimentarPadrao",
                table: "tbReceitaAlimentarPadrao_X_Alimento",
                column: "IdReceitaAlimentarPadrao");

            migrationBuilder.CreateIndex(
                name: "IX_tbReceitaMedicaPadrao_IdProfissional",
                table: "tbReceitaMedicaPadrao",
                column: "IdProfissional");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbAntropometria");

            migrationBuilder.DropTable(
                name: "tbEscalaBristol_Paciente_Consulta");

            migrationBuilder.DropTable(
                name: "tbExame_X_Pacientes");

            migrationBuilder.DropTable(
                name: "tbExameFisico");

            migrationBuilder.DropTable(
                name: "tbGrupoPatologico_X_Patologia");

            migrationBuilder.DropTable(
                name: "tbHistoriaPatologica");

            migrationBuilder.DropTable(
                name: "tbHistoricoAlimentarNutricional");

            migrationBuilder.DropTable(
                name: "tbHistoricoDoencaAtual");

            migrationBuilder.DropTable(
                name: "tbHistoricoSocialAlimentar");

            migrationBuilder.DropTable(
                name: "tbMedico_Paciente");

            migrationBuilder.DropTable(
                name: "tbRastreamentoMetabolico");

            migrationBuilder.DropTable(
                name: "tbReceitaAlimentarPadrao_X_Alimento");

            migrationBuilder.DropTable(
                name: "tbReceitaMedicaPadrao");

            migrationBuilder.DropTable(
                name: "tbEscalaBristol");

            migrationBuilder.DropTable(
                name: "tbExame");

            migrationBuilder.DropTable(
                name: "tbGrupoPatologico");

            migrationBuilder.DropTable(
                name: "tbPatologia");

            migrationBuilder.DropTable(
                name: "tbHoraPaciente_Profissional");

            migrationBuilder.DropTable(
                name: "tbRastreamentoResposta");

            migrationBuilder.DropTable(
                name: "tbAlimento");

            migrationBuilder.DropTable(
                name: "tbReceitaAlimentarPadrao");

            migrationBuilder.DropTable(
                name: "tbPaciente");

            migrationBuilder.DropTable(
                name: "tbPergunta");

            migrationBuilder.DropTable(
                name: "tbProfissional");

            migrationBuilder.DropTable(
                name: "tbCidade");

            migrationBuilder.DropTable(
                name: "tbContrato");

            migrationBuilder.DropTable(
                name: "tbTipoAcesso");

            migrationBuilder.DropTable(
                name: "tbEstado");

            migrationBuilder.DropTable(
                name: "tbPlano");

            migrationBuilder.DropTable(
                name: "tbPais");
        }
    }
}
