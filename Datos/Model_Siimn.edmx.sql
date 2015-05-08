
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2015 11:09:04
-- Generated from EDMX file: C:\Users\MARKETING\Documents\Visual Studio 2010\Projects\Siimn\Datos\Model_Siimn.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_centroacucentro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[acucentr] DROP CONSTRAINT [fk_centroacucentro];
GO
IF OBJECT_ID(N'[dbo].[fk_ciaacucentro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[acucentr] DROP CONSTRAINT [fk_ciaacucentro];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentaacucentro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[acucentr] DROP CONSTRAINT [fk_cuentaacucentro];
GO
IF OBJECT_ID(N'[dbo].[fk_nitacucentro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[acucentr] DROP CONSTRAINT [fk_nitacucentro];
GO
IF OBJECT_ID(N'[dbo].[fk_modulocajero]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[cajero] DROP CONSTRAINT [fk_modulocajero];
GO
IF OBJECT_ID(N'[dbo].[fk_campo10formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo10formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo11formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo11formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo12formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo12formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo13formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo13formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo14formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo14formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo15formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo15formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo16formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo16formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo1formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo1formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo2formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo2formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo3formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo3formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo4formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo4formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo5formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo5formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo6formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo6formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo7formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo7formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo8formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo8formato];
GO
IF OBJECT_ID(N'[dbo].[fk_campo9formato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatomedios] DROP CONSTRAINT [fk_campo9formato];
GO
IF OBJECT_ID(N'[dbo].[fk_centromovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_centromovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_centropresupuesto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[presupuesto] DROP CONSTRAINT [fk_centropresupuesto];
GO
IF OBJECT_ID(N'[dbo].[fk_ciudadcliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[cliente] DROP CONSTRAINT [fk_ciudadcliente];
GO
IF OBJECT_ID(N'[dbo].[fk_ciudadnits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maenits] DROP CONSTRAINT [fk_ciudadnits];
GO
IF OBJECT_ID(N'[dbo].[fk_ciudadsucursal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sucursal] DROP CONSTRAINT [fk_ciudadsucursal];
GO
IF OBJECT_ID(N'[dbo].[fk_deptociudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ciudad] DROP CONSTRAINT [fk_deptociudad];
GO
IF OBJECT_ID(N'[dbo].[fk_clientedatoscliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maecli] DROP CONSTRAINT [fk_clientedatoscliente];
GO
IF OBJECT_ID(N'[dbo].[fk_tipodtocliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[cliente] DROP CONSTRAINT [fk_tipodtocliente];
GO
IF OBJECT_ID(N'[dbo].[fk_ciasucursal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sucursal] DROP CONSTRAINT [fk_ciasucursal];
GO
IF OBJECT_ID(N'[dbo].[fk_usercia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[conexuser] DROP CONSTRAINT [fk_usercia];
GO
IF OBJECT_ID(N'[dbo].[fk_compromovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_compromovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_comprtrac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maetrac] DROP CONSTRAINT [fk_comprtrac];
GO
IF OBJECT_ID(N'[dbo].[fk_userconex]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[conexuser] DROP CONSTRAINT [fk_userconex];
GO
IF OBJECT_ID(N'[dbo].[fk_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [fk_usuario];
GO
IF OBJECT_ID(N'[dbo].[fk_paisdept]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[departamento] DROP CONSTRAINT [fk_paisdept];
GO
IF OBJECT_ID(N'[dbo].[fk_tipoformato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formato] DROP CONSTRAINT [fk_tipoformato];
GO
IF OBJECT_ID(N'[dbo].[fk_formatomedioscuenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maeconta] DROP CONSTRAINT [fk_formatomedioscuenta];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentafinforbpyg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatosbpyg] DROP CONSTRAINT [fk_cuentafinforbpyg];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentainifombpyg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formatosbpyg] DROP CONSTRAINT [fk_cuentainifombpyg];
GO
IF OBJECT_ID(N'[dbo].[fk_sucursalinfla]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[inflacion] DROP CONSTRAINT [fk_sucursalinfla];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentamaecli]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maecli] DROP CONSTRAINT [fk_cuentamaecli];
GO
IF OBJECT_ID(N'[dbo].[fk_vendedorcliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maecli] DROP CONSTRAINT [fk_vendedorcliente];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentacueaju]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maeconta] DROP CONSTRAINT [fk_cuentacueaju];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentacuecierre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maeconta] DROP CONSTRAINT [fk_cuentacuecierre];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentacuecor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maeconta] DROP CONSTRAINT [fk_cuentacuecor];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentamovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_cuentamovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentapagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maepagos] DROP CONSTRAINT [fk_cuentapagos];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentapresupuesto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[presupuesto] DROP CONSTRAINT [fk_cuentapresupuesto];
GO
IF OBJECT_ID(N'[dbo].[fk_cuentasaldos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[saldoscuentas] DROP CONSTRAINT [fk_cuentasaldos];
GO
IF OBJECT_ID(N'[dbo].[fk_nitcuenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maeconta] DROP CONSTRAINT [fk_nitcuenta];
GO
IF OBJECT_ID(N'[dbo].[fk_nitmovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_nitmovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_nitpagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maepagos] DROP CONSTRAINT [fk_nitpagos];
GO
IF OBJECT_ID(N'[dbo].[fk_nittrib]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maetribut] DROP CONSTRAINT [fk_nittrib];
GO
IF OBJECT_ID(N'[dbo].[fk_tiponitnits]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maenits] DROP CONSTRAINT [fk_tiponitnits];
GO
IF OBJECT_ID(N'[dbo].[fk_ciapagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maepagos] DROP CONSTRAINT [fk_ciapagos];
GO
IF OBJECT_ID(N'[dbo].[fk_modulotrac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[maetrac] DROP CONSTRAINT [fk_modulotrac];
GO
IF OBJECT_ID(N'[dbo].[fk_tipodocmovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_tipodocmovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_moduloppalmodulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[modulo] DROP CONSTRAINT [fk_moduloppalmodulo];
GO
IF OBJECT_ID(N'[dbo].[fk_permmod]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[permiso] DROP CONSTRAINT [fk_permmod];
GO
IF OBJECT_ID(N'[dbo].[fk_modulomovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_modulomovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_moduloparametro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[parametro] DROP CONSTRAINT [fk_moduloparametro];
GO
IF OBJECT_ID(N'[dbo].[fk_ciamovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_ciamovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_usuarioactmovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_usuarioactmovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_usuariomovimi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[movimi] DROP CONSTRAINT [fk_usuariomovimi];
GO
IF OBJECT_ID(N'[dbo].[fk_userperm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[permiso] DROP CONSTRAINT [fk_userperm];
GO
IF OBJECT_ID(N'[dbo].[fk_ciapresupuesto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[presupuesto] DROP CONSTRAINT [fk_ciapresupuesto];
GO
IF OBJECT_ID(N'[dbo].[fk_sucursalsaldos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[saldoscuentas] DROP CONSTRAINT [fk_sucursalsaldos];
GO
IF OBJECT_ID(N'[dbo].[fk_ciausxcia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuariocia] DROP CONSTRAINT [fk_ciausxcia];
GO
IF OBJECT_ID(N'[dbo].[fk_sucursalvendedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[vendedor] DROP CONSTRAINT [fk_sucursalvendedor];
GO
IF OBJECT_ID(N'[dbo].[fk_userusxcia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuariocia] DROP CONSTRAINT [fk_userusxcia];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[acucentr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[acucentr];
GO
IF OBJECT_ID(N'[dbo].[cajero]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cajero];
GO
IF OBJECT_ID(N'[dbo].[campoformedios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[campoformedios];
GO
IF OBJECT_ID(N'[dbo].[centrocostos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[centrocostos];
GO
IF OBJECT_ID(N'[dbo].[ciudad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ciudad];
GO
IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO
IF OBJECT_ID(N'[dbo].[compania]', 'U') IS NOT NULL
    DROP TABLE [dbo].[compania];
GO
IF OBJECT_ID(N'[dbo].[comprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[comprobante];
GO
IF OBJECT_ID(N'[dbo].[conceptospagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[conceptospagos];
GO
IF OBJECT_ID(N'[dbo].[conexuser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[conexuser];
GO
IF OBJECT_ID(N'[dbo].[datosusuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[datosusuario];
GO
IF OBJECT_ID(N'[dbo].[departamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[departamento];
GO
IF OBJECT_ID(N'[dbo].[formaspago]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formaspago];
GO
IF OBJECT_ID(N'[dbo].[formato]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formato];
GO
IF OBJECT_ID(N'[dbo].[formatomedios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formatomedios];
GO
IF OBJECT_ID(N'[dbo].[formatosbpyg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formatosbpyg];
GO
IF OBJECT_ID(N'[dbo].[inflacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[inflacion];
GO
IF OBJECT_ID(N'[dbo].[maebanta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maebanta];
GO
IF OBJECT_ID(N'[dbo].[maecli]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maecli];
GO
IF OBJECT_ID(N'[dbo].[maeconcc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maeconcc];
GO
IF OBJECT_ID(N'[dbo].[maeconta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maeconta];
GO
IF OBJECT_ID(N'[dbo].[maenits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maenits];
GO
IF OBJECT_ID(N'[dbo].[maepagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maepagos];
GO
IF OBJECT_ID(N'[dbo].[maetrac]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maetrac];
GO
IF OBJECT_ID(N'[dbo].[maetribut]', 'U') IS NOT NULL
    DROP TABLE [dbo].[maetribut];
GO
IF OBJECT_ID(N'[dbo].[modulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[modulo];
GO
IF OBJECT_ID(N'[dbo].[moduloppal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[moduloppal];
GO
IF OBJECT_ID(N'[dbo].[movimi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[movimi];
GO
IF OBJECT_ID(N'[dbo].[pais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[pais];
GO
IF OBJECT_ID(N'[dbo].[parametro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[parametro];
GO
IF OBJECT_ID(N'[dbo].[permiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[permiso];
GO
IF OBJECT_ID(N'[dbo].[presupuesto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[presupuesto];
GO
IF OBJECT_ID(N'[dbo].[saldoscuentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[saldoscuentas];
GO
IF OBJECT_ID(N'[dbo].[sucursal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sucursal];
GO
IF OBJECT_ID(N'[dbo].[tipoformato]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipoformato];
GO
IF OBJECT_ID(N'[dbo].[tiponit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tiponit];
GO
IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO
IF OBJECT_ID(N'[dbo].[usuariocia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuariocia];
GO
IF OBJECT_ID(N'[dbo].[vendedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[vendedor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'acucentr'
CREATE TABLE [dbo].[acucentr] (
    [idacucentr] int IDENTITY(1,1) NOT NULL,
    [idsucursal] int  NOT NULL,
    [anio] varchar(4)  NULL,
    [mes] int  NOT NULL,
    [idcentro] int  NULL,
    [idnit] int  NULL,
    [idcuenta] int  NOT NULL,
    [saldomes] decimal(10,0)  NOT NULL,
    [debimes] decimal(10,0)  NOT NULL,
    [credimes] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'cajero'
CREATE TABLE [dbo].[cajero] (
    [idcajero] int  NOT NULL,
    [nombrecaje] varchar(45)  NOT NULL,
    [usuariocaje] varchar(10)  NOT NULL,
    [clave] varchar(32)  NOT NULL,
    [idmodulo] int  NOT NULL
);
GO

-- Creating table 'campoformedios'
CREATE TABLE [dbo].[campoformedios] (
    [idcampoformato] int  NOT NULL,
    [nombrecampo] varchar(45)  NOT NULL
);
GO

-- Creating table 'centrocostos'
CREATE TABLE [dbo].[centrocostos] (
    [idcentro] int  NOT NULL,
    [nombrecentro] varchar(45)  NOT NULL
);
GO

-- Creating table 'ciudad'
CREATE TABLE [dbo].[ciudad] (
    [idciudad] int IDENTITY(1,1) NOT NULL,
    [codigodepto] int  NOT NULL,
    [codigociudad] varchar(3)  NOT NULL,
    [nombreciudad] varchar(45)  NOT NULL
);
GO

-- Creating table 'cliente'
CREATE TABLE [dbo].[cliente] (
    [idcliente] int IDENTITY(1,1) NOT NULL,
    [idtipodto] int  NOT NULL,
    [documento] varchar(12)  NOT NULL,
    [digito] varchar(1)  NULL,
    [nombre] varchar(50)  NOT NULL,
    [idciudad] int  NOT NULL,
    [direccion] varchar(45)  NULL,
    [telefono] varchar(10)  NULL,
    [celular] varchar(10)  NULL,
    [fax] varchar(10)  NULL,
    [email] varchar(45)  NULL
);
GO

-- Creating table 'compania'
CREATE TABLE [dbo].[compania] (
    [idcompania] int  NOT NULL,
    [nombrecia] varchar(45)  NOT NULL,
    [nit] varchar(10)  NOT NULL,
    [digito] varchar(1)  NOT NULL
);
GO

-- Creating table 'comprobante'
CREATE TABLE [dbo].[comprobante] (
    [codigcomprob] int  NOT NULL,
    [descripcomprob] varchar(45)  NOT NULL,
    [consecutivo] bool  NOT NULL,
    [numsiguiente] int  NULL,
    [codigootra] varchar(3)  NOT NULL
);
GO

-- Creating table 'conceptospagos'
CREATE TABLE [dbo].[conceptospagos] (
    [idconceptospago] int  NOT NULL,
    [descripconcep] varchar(45)  NOT NULL,
    [cuenta] varchar(10)  NOT NULL,
    [codformaspago] varchar(2)  NOT NULL,
    [porcentaje] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'conexuser'
CREATE TABLE [dbo].[conexuser] (
    [idconexion] int IDENTITY(1,1) NOT NULL,
    [idusuario] int  NOT NULL,
    [idcompania] int  NOT NULL,
    [fechaconex] datetime  NOT NULL,
    [fechadescon] datetime  NOT NULL
);
GO

-- Creating table 'datosusuario'
CREATE TABLE [dbo].[datosusuario] (
    [idusuariodat] int IDENTITY(1,1) NOT NULL,
    [cedula] varchar(10)  NOT NULL,
    [nombresusuario] varchar(30)  NOT NULL,
    [apellidosusuario] varchar(30)  NOT NULL,
    [telefonousuario] varchar(10)  NOT NULL,
    [direccionusuario] varchar(45)  NULL
);
GO

-- Creating table 'departamento'
CREATE TABLE [dbo].[departamento] (
    [iddept] int IDENTITY(1,1) NOT NULL,
    [idpais] int  NOT NULL,
    [codigodepto] varchar(2)  NOT NULL,
    [nombredept] varchar(45)  NOT NULL
);
GO

-- Creating table 'formaspago'
CREATE TABLE [dbo].[formaspago] (
    [idformaspago] int IDENTITY(1,1) NOT NULL,
    [codformaspago] varchar(2)  NOT NULL,
    [nombreforma] varchar(45)  NOT NULL,
    [sivence] bool  NOT NULL
);
GO

-- Creating table 'formato'
CREATE TABLE [dbo].[formato] (
    [idformato] int IDENTITY(1,1) NOT NULL,
    [idmoduloppal] varchar(2)  NOT NULL,
    [codigofor] int  NOT NULL,
    [codigotipo] int  NOT NULL,
    [activo] bool  NOT NULL,
    [fila] int  NULL,
    [columna] int  NULL,
    [condensa] bool  NOT NULL,
    [presentacion] varchar(45)  NULL,
    [titulo] varchar(45)  NULL
);
GO

-- Creating table 'formatomedios'
CREATE TABLE [dbo].[formatomedios] (
    [idformatomedios] int IDENTITY(1,1) NOT NULL,
    [numeroformatos] varchar(6)  NOT NULL,
    [idcampo1] int  NOT NULL,
    [idcampo2] int  NOT NULL,
    [idcampo3] int  NOT NULL,
    [idcampo4] int  NOT NULL,
    [idcampo5] int  NOT NULL,
    [idcampo6] int  NOT NULL,
    [idcampo7] int  NOT NULL,
    [idcampo8] int  NOT NULL,
    [idcampo9] int  NOT NULL,
    [idcampo10] int  NOT NULL,
    [idcampo11] int  NULL,
    [idcampo12] int  NULL,
    [idcampo13] int  NULL,
    [idcampo14] int  NULL,
    [idcampo15] int  NULL,
    [idcampo16] int  NULL
);
GO

-- Creating table 'formatosbpyg'
CREATE TABLE [dbo].[formatosbpyg] (
    [idformato] int IDENTITY(1,1) NOT NULL,
    [tipoformato] varchar(1)  NOT NULL,
    [clasemayor] varchar(1)  NULL,
    [linea] varchar(2)  NULL,
    [nombref] varchar(45)  NOT NULL,
    [cuentaini] int  NULL,
    [cuentafin] int  NULL
);
GO

-- Creating table 'inflacion'
CREATE TABLE [dbo].[inflacion] (
    [idinflacion] int IDENTITY(1,1) NOT NULL,
    [idsucursal] int  NOT NULL,
    [mes] varchar(2)  NOT NULL,
    [inflamensual] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'maebanta'
CREATE TABLE [dbo].[maebanta] (
    [idbanta] int  NOT NULL,
    [codigobanta] varchar(2)  NOT NULL,
    [nombrebanta] varchar(45)  NOT NULL,
    [tipobanta] varchar(1)  NOT NULL
);
GO

-- Creating table 'maecli'
CREATE TABLE [dbo].[maecli] (
    [codigocli] int IDENTITY(1,1) NOT NULL,
    [idcliente] int  NOT NULL,
    [facturanombre] varchar(50)  NOT NULL,
    [bloqueado] bool  NOT NULL,
    [direccionenvio] varchar(50)  NOT NULL,
    [plazo] int  NOT NULL,
    [cupo] decimal(10,0)  NOT NULL,
    [descuento] decimal(10,0)  NOT NULL,
    [regimen] varchar(1)  NOT NULL,
    [grancotribu] bool  NOT NULL,
    [ppago1] decimal(10,0)  NULL,
    [ppago2] decimal(10,0)  NULL,
    [causareteica] bool  NOT NULL,
    [aplicareteica] bool  NOT NULL,
    [causareteiva] bool  NOT NULL,
    [descuentareteiva] bool  NOT NULL,
    [retexcomprar] bool  NOT NULL,
    [descontretenvend] bool  NOT NULL,
    [porretencion] decimal(10,0)  NULL,
    [jefecompra] varchar(45)  NOT NULL,
    [comprador] varchar(45)  NOT NULL,
    [cuenta] int  NOT NULL,
    [idvendedor] int  NOT NULL
);
GO

-- Creating table 'maeconcc'
CREATE TABLE [dbo].[maeconcc] (
    [idconcepto] int  NOT NULL,
    [descripconcepto] varchar(45)  NOT NULL
);
GO

-- Creating table 'maeconta'
CREATE TABLE [dbo].[maeconta] (
    [idcuenta] int IDENTITY(1,1) NOT NULL,
    [cuenta] varchar(10)  NOT NULL,
    [tipocta] varchar(1)  NOT NULL,
    [nombre] varchar(70)  NOT NULL,
    [pidenit] bool  NOT NULL,
    [centro] bool  NOT NULL,
    [ajustesinteg] bool  NOT NULL,
    [idnitajustes] int  NULL,
    [cueaju] int  NULL,
    [cuencorre] int  NULL,
    [ajudoc] varchar(1)  NULL,
    [retencion] bool  NOT NULL,
    [porete] decimal(10,0)  NULL,
    [conceprete] varchar(70)  NULL,
    [reteica] bool  NOT NULL,
    [poreteica] decimal(10,0)  NULL,
    [concepreteica] varchar(45)  NULL,
    [cuentacierre] int  NULL,
    [codformatomedios] int  NULL
);
GO

-- Creating table 'maenits'
CREATE TABLE [dbo].[maenits] (
    [idnit] int IDENTITY(1,1) NOT NULL,
    [idtiponit] int  NOT NULL,
    [nit] varchar(12)  NOT NULL,
    [digito] varchar(1)  NOT NULL,
    [nombrenit] varchar(45)  NOT NULL,
    [idciudad] int  NOT NULL,
    [acteconomic] varchar(10)  NOT NULL,
    [direccion] varchar(60)  NULL,
    [telefono] varchar(10)  NULL,
    [celular] varchar(10)  NOT NULL,
    [email] varchar(45)  NULL
);
GO

-- Creating table 'maepagos'
CREATE TABLE [dbo].[maepagos] (
    [idpagos] int  NOT NULL,
    [idsucursal] int  NOT NULL,
    [anio] varchar(4)  NOT NULL,
    [mes] int  NOT NULL,
    [cuenta] int  NOT NULL,
    [idnit] int  NOT NULL,
    [saldomes] decimal(10,0)  NOT NULL,
    [debimes] decimal(10,0)  NOT NULL,
    [credimes] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'maetrac'
CREATE TABLE [dbo].[maetrac] (
    [idtransaccion] int  NOT NULL,
    [codigotrac] varchar(2)  NOT NULL,
    [idmoduloppal] int  NOT NULL,
    [nombretrac] varchar(45)  NOT NULL,
    [afectasaldo] varchar(1)  NOT NULL,
    [afectaotro] bool  NOT NULL,
    [generaasiento] bool  NOT NULL,
    [consecutivo] bool  NOT NULL,
    [numeroactual] int  NULL,
    [codigcomp] int  NULL
);
GO

-- Creating table 'maetribut'
CREATE TABLE [dbo].[maetribut] (
    [idtributario] int  NOT NULL,
    [codigotrib] varchar(5)  NOT NULL,
    [nombre] varchar(45)  NOT NULL,
    [tope] decimal(10,0)  NULL,
    [idnittope] int  NULL
);
GO

-- Creating table 'modulo'
CREATE TABLE [dbo].[modulo] (
    [idmodulo] int  NOT NULL,
    [idmoduloppal] int  NOT NULL,
    [nombremod] varchar(45)  NOT NULL
);
GO

-- Creating table 'moduloppal'
CREATE TABLE [dbo].[moduloppal] (
    [idmodulo] int  NOT NULL,
    [codigmoduloppal] varchar(2)  NOT NULL,
    [nombremodppal] varchar(45)  NOT NULL
);
GO

-- Creating table 'movimi'
CREATE TABLE [dbo].[movimi] (
    [idmovimiento] int IDENTITY(1,1) NOT NULL,
    [idasiento] varchar(18)  NOT NULL,
    [idsucursal] int  NOT NULL,
    [mes] int  NOT NULL,
    [anio] varchar(4)  NOT NULL,
    [fecha] datetime  NOT NULL,
    [documento] varchar(15)  NOT NULL,
    [idmoduloimprime] int  NOT NULL,
    [idtipodocumento] int  NULL,
    [codigcomprob] int  NOT NULL,
    [cuenta] int  NOT NULL,
    [detalle] varchar(55)  NOT NULL,
    [idcentro] int  NULL,
    [idnit] int  NULL,
    [referencia] varchar(10)  NULL,
    [valordebito] decimal(10,0)  NOT NULL,
    [valorcredito] decimal(10,0)  NOT NULL,
    [baseimpuesto] decimal(10,0)  NOT NULL,
    [valorica] decimal(10,0)  NOT NULL,
    [entrada] int  NULL,
    [asientofijo] bool  NOT NULL,
    [actualizado] bool  NOT NULL,
    [idusuario] int  NOT NULL,
    [fechagrabacion] datetime  NOT NULL,
    [idusuarioact] int  NULL,
    [fechaact] datetime  NULL
);
GO

-- Creating table 'pais'
CREATE TABLE [dbo].[pais] (
    [idpais] int  NOT NULL,
    [codpais] varchar(3)  NOT NULL,
    [nombrepais] varchar(45)  NOT NULL
);
GO

-- Creating table 'parametro'
CREATE TABLE [dbo].[parametro] (
    [idparametro] int IDENTITY(1,1) NOT NULL,
    [nombreparametro] varchar(45)  NOT NULL,
    [idmoduloppal] int  NOT NULL,
    [descriparam] varchar(70)  NOT NULL,
    [valorparam] varchar(75)  NOT NULL
);
GO

-- Creating table 'permiso'
CREATE TABLE [dbo].[permiso] (
    [idpermiso] int IDENTITY(1,1) NOT NULL,
    [idusuario] int  NOT NULL,
    [idmodulo] int  NOT NULL,
    [permitido] bool  NOT NULL
);
GO

-- Creating table 'presupuesto'
CREATE TABLE [dbo].[presupuesto] (
    [idpresupuesto] int IDENTITY(1,1) NOT NULL,
    [idsucursal] int  NOT NULL,
    [cuenta] int  NOT NULL,
    [idcentro] int  NOT NULL,
    [anio] varchar(4)  NOT NULL,
    [mes] int  NOT NULL,
    [cantidad] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'saldoscuentas'
CREATE TABLE [dbo].[saldoscuentas] (
    [idsaldoscuentas] int  NOT NULL,
    [idsucursal] int  NOT NULL,
    [cuenta] int  NOT NULL,
    [anio] varchar(4)  NOT NULL,
    [mes] int  NOT NULL,
    [saldomes] decimal(10,0)  NOT NULL,
    [credimes] decimal(10,0)  NOT NULL,
    [debimes] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'sucursal'
CREATE TABLE [dbo].[sucursal] (
    [idsucursal] int  NOT NULL,
    [idcompania] int  NOT NULL,
    [nombresucursal] varchar(45)  NOT NULL,
    [idciudad] int  NOT NULL,
    [direccion] varchar(70)  NOT NULL,
    [telefono] varchar(10)  NOT NULL,
    [paginaocorreo] varchar(50)  NULL
);
GO

-- Creating table 'tipoformato'
CREATE TABLE [dbo].[tipoformato] (
    [codigotipo] int  NOT NULL,
    [nombretipo] varchar(45)  NOT NULL
);
GO

-- Creating table 'tiponit'
CREATE TABLE [dbo].[tiponit] (
    [idtiponit] int IDENTITY(1,1) NOT NULL,
    [codigtiponit] varchar(1)  NOT NULL,
    [nombretipo] varchar(45)  NOT NULL
);
GO

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [idusuario] int IDENTITY(1,1) NOT NULL,
    [idusuariodatos] int  NOT NULL,
    [user] varchar(10)  NOT NULL,
    [contrasena] varchar(32)  NOT NULL,
    [fechaulticonex] datetime  NULL,
    [ultimobloqueo] datetime  NULL,
    [intentosfallidos] int  NOT NULL,
    [bloqueado] bool  NOT NULL,
    [conectado] bool  NOT NULL
);
GO

-- Creating table 'usuariocia'
CREATE TABLE [dbo].[usuariocia] (
    [idusercia] int IDENTITY(1,1) NOT NULL,
    [idcompania] int  NOT NULL,
    [idusuario] int  NOT NULL
);
GO

-- Creating table 'vendedor'
CREATE TABLE [dbo].[vendedor] (
    [idvendedor] int  NOT NULL,
    [nombrevendedor] varchar(45)  NOT NULL,
    [cedula] varchar(45)  NOT NULL,
    [tipo] varchar(1)  NOT NULL,
    [telefono] varchar(10)  NOT NULL,
    [emailvend] varchar(45)  NULL,
    [direcvend] varchar(45)  NULL,
    [activo] bool  NOT NULL,
    [comisionrango] bool  NOT NULL,
    [comision] decimal(10,0)  NOT NULL,
    [idcompania] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idacucentr] in table 'acucentr'
ALTER TABLE [dbo].[acucentr]
ADD CONSTRAINT [PK_acucentr]
    PRIMARY KEY CLUSTERED ([idacucentr] ASC);
GO

-- Creating primary key on [idcajero] in table 'cajero'
ALTER TABLE [dbo].[cajero]
ADD CONSTRAINT [PK_cajero]
    PRIMARY KEY CLUSTERED ([idcajero] ASC);
GO

-- Creating primary key on [idcampoformato] in table 'campoformedios'
ALTER TABLE [dbo].[campoformedios]
ADD CONSTRAINT [PK_campoformedios]
    PRIMARY KEY CLUSTERED ([idcampoformato] ASC);
GO

-- Creating primary key on [idcentro] in table 'centrocostos'
ALTER TABLE [dbo].[centrocostos]
ADD CONSTRAINT [PK_centrocostos]
    PRIMARY KEY CLUSTERED ([idcentro] ASC);
GO

-- Creating primary key on [idciudad] in table 'ciudad'
ALTER TABLE [dbo].[ciudad]
ADD CONSTRAINT [PK_ciudad]
    PRIMARY KEY CLUSTERED ([idciudad] ASC);
GO

-- Creating primary key on [idcliente] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [PK_cliente]
    PRIMARY KEY CLUSTERED ([idcliente] ASC);
GO

-- Creating primary key on [idcompania] in table 'compania'
ALTER TABLE [dbo].[compania]
ADD CONSTRAINT [PK_compania]
    PRIMARY KEY CLUSTERED ([idcompania] ASC);
GO

-- Creating primary key on [codigcomprob] in table 'comprobante'
ALTER TABLE [dbo].[comprobante]
ADD CONSTRAINT [PK_comprobante]
    PRIMARY KEY CLUSTERED ([codigcomprob] ASC);
GO

-- Creating primary key on [idconceptospago] in table 'conceptospagos'
ALTER TABLE [dbo].[conceptospagos]
ADD CONSTRAINT [PK_conceptospagos]
    PRIMARY KEY CLUSTERED ([idconceptospago] ASC);
GO

-- Creating primary key on [idconexion] in table 'conexuser'
ALTER TABLE [dbo].[conexuser]
ADD CONSTRAINT [PK_conexuser]
    PRIMARY KEY CLUSTERED ([idconexion] ASC);
GO

-- Creating primary key on [idusuariodat] in table 'datosusuario'
ALTER TABLE [dbo].[datosusuario]
ADD CONSTRAINT [PK_datosusuario]
    PRIMARY KEY CLUSTERED ([idusuariodat] ASC);
GO

-- Creating primary key on [iddept] in table 'departamento'
ALTER TABLE [dbo].[departamento]
ADD CONSTRAINT [PK_departamento]
    PRIMARY KEY CLUSTERED ([iddept] ASC);
GO

-- Creating primary key on [idformaspago] in table 'formaspago'
ALTER TABLE [dbo].[formaspago]
ADD CONSTRAINT [PK_formaspago]
    PRIMARY KEY CLUSTERED ([idformaspago] ASC);
GO

-- Creating primary key on [idformato] in table 'formato'
ALTER TABLE [dbo].[formato]
ADD CONSTRAINT [PK_formato]
    PRIMARY KEY CLUSTERED ([idformato] ASC);
GO

-- Creating primary key on [idformatomedios] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [PK_formatomedios]
    PRIMARY KEY CLUSTERED ([idformatomedios] ASC);
GO

-- Creating primary key on [idformato] in table 'formatosbpyg'
ALTER TABLE [dbo].[formatosbpyg]
ADD CONSTRAINT [PK_formatosbpyg]
    PRIMARY KEY CLUSTERED ([idformato] ASC);
GO

-- Creating primary key on [idinflacion] in table 'inflacion'
ALTER TABLE [dbo].[inflacion]
ADD CONSTRAINT [PK_inflacion]
    PRIMARY KEY CLUSTERED ([idinflacion] ASC);
GO

-- Creating primary key on [idbanta] in table 'maebanta'
ALTER TABLE [dbo].[maebanta]
ADD CONSTRAINT [PK_maebanta]
    PRIMARY KEY CLUSTERED ([idbanta] ASC);
GO

-- Creating primary key on [codigocli] in table 'maecli'
ALTER TABLE [dbo].[maecli]
ADD CONSTRAINT [PK_maecli]
    PRIMARY KEY CLUSTERED ([codigocli] ASC);
GO

-- Creating primary key on [idconcepto] in table 'maeconcc'
ALTER TABLE [dbo].[maeconcc]
ADD CONSTRAINT [PK_maeconcc]
    PRIMARY KEY CLUSTERED ([idconcepto] ASC);
GO

-- Creating primary key on [idcuenta] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [PK_maeconta]
    PRIMARY KEY CLUSTERED ([idcuenta] ASC);
GO

-- Creating primary key on [idnit] in table 'maenits'
ALTER TABLE [dbo].[maenits]
ADD CONSTRAINT [PK_maenits]
    PRIMARY KEY CLUSTERED ([idnit] ASC);
GO

-- Creating primary key on [idpagos] in table 'maepagos'
ALTER TABLE [dbo].[maepagos]
ADD CONSTRAINT [PK_maepagos]
    PRIMARY KEY CLUSTERED ([idpagos] ASC);
GO

-- Creating primary key on [idtransaccion] in table 'maetrac'
ALTER TABLE [dbo].[maetrac]
ADD CONSTRAINT [PK_maetrac]
    PRIMARY KEY CLUSTERED ([idtransaccion] ASC);
GO

-- Creating primary key on [idtributario] in table 'maetribut'
ALTER TABLE [dbo].[maetribut]
ADD CONSTRAINT [PK_maetribut]
    PRIMARY KEY CLUSTERED ([idtributario] ASC);
GO

-- Creating primary key on [idmodulo] in table 'modulo'
ALTER TABLE [dbo].[modulo]
ADD CONSTRAINT [PK_modulo]
    PRIMARY KEY CLUSTERED ([idmodulo] ASC);
GO

-- Creating primary key on [idmodulo] in table 'moduloppal'
ALTER TABLE [dbo].[moduloppal]
ADD CONSTRAINT [PK_moduloppal]
    PRIMARY KEY CLUSTERED ([idmodulo] ASC);
GO

-- Creating primary key on [idmovimiento] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [PK_movimi]
    PRIMARY KEY CLUSTERED ([idmovimiento] ASC);
GO

-- Creating primary key on [idpais] in table 'pais'
ALTER TABLE [dbo].[pais]
ADD CONSTRAINT [PK_pais]
    PRIMARY KEY CLUSTERED ([idpais] ASC);
GO

-- Creating primary key on [idparametro] in table 'parametro'
ALTER TABLE [dbo].[parametro]
ADD CONSTRAINT [PK_parametro]
    PRIMARY KEY CLUSTERED ([idparametro] ASC);
GO

-- Creating primary key on [idpermiso] in table 'permiso'
ALTER TABLE [dbo].[permiso]
ADD CONSTRAINT [PK_permiso]
    PRIMARY KEY CLUSTERED ([idpermiso] ASC);
GO

-- Creating primary key on [idpresupuesto] in table 'presupuesto'
ALTER TABLE [dbo].[presupuesto]
ADD CONSTRAINT [PK_presupuesto]
    PRIMARY KEY CLUSTERED ([idpresupuesto] ASC);
GO

-- Creating primary key on [idsaldoscuentas] in table 'saldoscuentas'
ALTER TABLE [dbo].[saldoscuentas]
ADD CONSTRAINT [PK_saldoscuentas]
    PRIMARY KEY CLUSTERED ([idsaldoscuentas] ASC);
GO

-- Creating primary key on [idsucursal] in table 'sucursal'
ALTER TABLE [dbo].[sucursal]
ADD CONSTRAINT [PK_sucursal]
    PRIMARY KEY CLUSTERED ([idsucursal] ASC);
GO

-- Creating primary key on [codigotipo] in table 'tipoformato'
ALTER TABLE [dbo].[tipoformato]
ADD CONSTRAINT [PK_tipoformato]
    PRIMARY KEY CLUSTERED ([codigotipo] ASC);
GO

-- Creating primary key on [idtiponit] in table 'tiponit'
ALTER TABLE [dbo].[tiponit]
ADD CONSTRAINT [PK_tiponit]
    PRIMARY KEY CLUSTERED ([idtiponit] ASC);
GO

-- Creating primary key on [idusuario] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([idusuario] ASC);
GO

-- Creating primary key on [idusercia] in table 'usuariocia'
ALTER TABLE [dbo].[usuariocia]
ADD CONSTRAINT [PK_usuariocia]
    PRIMARY KEY CLUSTERED ([idusercia] ASC);
GO

-- Creating primary key on [idvendedor] in table 'vendedor'
ALTER TABLE [dbo].[vendedor]
ADD CONSTRAINT [PK_vendedor]
    PRIMARY KEY CLUSTERED ([idvendedor] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idcentro] in table 'acucentr'
ALTER TABLE [dbo].[acucentr]
ADD CONSTRAINT [fk_centroacucentro]
    FOREIGN KEY ([idcentro])
    REFERENCES [dbo].[centrocostos]
        ([idcentro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_centroacucentro'
CREATE INDEX [IX_fk_centroacucentro]
ON [dbo].[acucentr]
    ([idcentro]);
GO

-- Creating foreign key on [idsucursal] in table 'acucentr'
ALTER TABLE [dbo].[acucentr]
ADD CONSTRAINT [fk_ciaacucentro]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciaacucentro'
CREATE INDEX [IX_fk_ciaacucentro]
ON [dbo].[acucentr]
    ([idsucursal]);
GO

-- Creating foreign key on [idcuenta] in table 'acucentr'
ALTER TABLE [dbo].[acucentr]
ADD CONSTRAINT [fk_cuentaacucentro]
    FOREIGN KEY ([idcuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentaacucentro'
CREATE INDEX [IX_fk_cuentaacucentro]
ON [dbo].[acucentr]
    ([idcuenta]);
GO

-- Creating foreign key on [idnit] in table 'acucentr'
ALTER TABLE [dbo].[acucentr]
ADD CONSTRAINT [fk_nitacucentro]
    FOREIGN KEY ([idnit])
    REFERENCES [dbo].[maenits]
        ([idnit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_nitacucentro'
CREATE INDEX [IX_fk_nitacucentro]
ON [dbo].[acucentr]
    ([idnit]);
GO

-- Creating foreign key on [idmodulo] in table 'cajero'
ALTER TABLE [dbo].[cajero]
ADD CONSTRAINT [fk_modulocajero]
    FOREIGN KEY ([idmodulo])
    REFERENCES [dbo].[modulo]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_modulocajero'
CREATE INDEX [IX_fk_modulocajero]
ON [dbo].[cajero]
    ([idmodulo]);
GO

-- Creating foreign key on [idcampo10] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo10formato]
    FOREIGN KEY ([idcampo10])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo10formato'
CREATE INDEX [IX_fk_campo10formato]
ON [dbo].[formatomedios]
    ([idcampo10]);
GO

-- Creating foreign key on [idcampo11] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo11formato]
    FOREIGN KEY ([idcampo11])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo11formato'
CREATE INDEX [IX_fk_campo11formato]
ON [dbo].[formatomedios]
    ([idcampo11]);
GO

-- Creating foreign key on [idcampo12] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo12formato]
    FOREIGN KEY ([idcampo12])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo12formato'
CREATE INDEX [IX_fk_campo12formato]
ON [dbo].[formatomedios]
    ([idcampo12]);
GO

-- Creating foreign key on [idcampo13] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo13formato]
    FOREIGN KEY ([idcampo13])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo13formato'
CREATE INDEX [IX_fk_campo13formato]
ON [dbo].[formatomedios]
    ([idcampo13]);
GO

-- Creating foreign key on [idcampo14] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo14formato]
    FOREIGN KEY ([idcampo14])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo14formato'
CREATE INDEX [IX_fk_campo14formato]
ON [dbo].[formatomedios]
    ([idcampo14]);
GO

-- Creating foreign key on [idcampo15] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo15formato]
    FOREIGN KEY ([idcampo15])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo15formato'
CREATE INDEX [IX_fk_campo15formato]
ON [dbo].[formatomedios]
    ([idcampo15]);
GO

-- Creating foreign key on [idcampo16] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo16formato]
    FOREIGN KEY ([idcampo16])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo16formato'
CREATE INDEX [IX_fk_campo16formato]
ON [dbo].[formatomedios]
    ([idcampo16]);
GO

-- Creating foreign key on [idcampo1] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo1formato]
    FOREIGN KEY ([idcampo1])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo1formato'
CREATE INDEX [IX_fk_campo1formato]
ON [dbo].[formatomedios]
    ([idcampo1]);
GO

-- Creating foreign key on [idcampo2] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo2formato]
    FOREIGN KEY ([idcampo2])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo2formato'
CREATE INDEX [IX_fk_campo2formato]
ON [dbo].[formatomedios]
    ([idcampo2]);
GO

-- Creating foreign key on [idcampo3] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo3formato]
    FOREIGN KEY ([idcampo3])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo3formato'
CREATE INDEX [IX_fk_campo3formato]
ON [dbo].[formatomedios]
    ([idcampo3]);
GO

-- Creating foreign key on [idcampo4] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo4formato]
    FOREIGN KEY ([idcampo4])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo4formato'
CREATE INDEX [IX_fk_campo4formato]
ON [dbo].[formatomedios]
    ([idcampo4]);
GO

-- Creating foreign key on [idcampo5] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo5formato]
    FOREIGN KEY ([idcampo5])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo5formato'
CREATE INDEX [IX_fk_campo5formato]
ON [dbo].[formatomedios]
    ([idcampo5]);
GO

-- Creating foreign key on [idcampo6] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo6formato]
    FOREIGN KEY ([idcampo6])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo6formato'
CREATE INDEX [IX_fk_campo6formato]
ON [dbo].[formatomedios]
    ([idcampo6]);
GO

-- Creating foreign key on [idcampo7] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo7formato]
    FOREIGN KEY ([idcampo7])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo7formato'
CREATE INDEX [IX_fk_campo7formato]
ON [dbo].[formatomedios]
    ([idcampo7]);
GO

-- Creating foreign key on [idcampo8] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo8formato]
    FOREIGN KEY ([idcampo8])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo8formato'
CREATE INDEX [IX_fk_campo8formato]
ON [dbo].[formatomedios]
    ([idcampo8]);
GO

-- Creating foreign key on [idcampo9] in table 'formatomedios'
ALTER TABLE [dbo].[formatomedios]
ADD CONSTRAINT [fk_campo9formato]
    FOREIGN KEY ([idcampo9])
    REFERENCES [dbo].[campoformedios]
        ([idcampoformato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_campo9formato'
CREATE INDEX [IX_fk_campo9formato]
ON [dbo].[formatomedios]
    ([idcampo9]);
GO

-- Creating foreign key on [idcentro] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_centromovimi]
    FOREIGN KEY ([idcentro])
    REFERENCES [dbo].[centrocostos]
        ([idcentro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_centromovimi'
CREATE INDEX [IX_fk_centromovimi]
ON [dbo].[movimi]
    ([idcentro]);
GO

-- Creating foreign key on [idcentro] in table 'presupuesto'
ALTER TABLE [dbo].[presupuesto]
ADD CONSTRAINT [fk_centropresupuesto]
    FOREIGN KEY ([idcentro])
    REFERENCES [dbo].[centrocostos]
        ([idcentro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_centropresupuesto'
CREATE INDEX [IX_fk_centropresupuesto]
ON [dbo].[presupuesto]
    ([idcentro]);
GO

-- Creating foreign key on [idciudad] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [fk_ciudadcliente]
    FOREIGN KEY ([idciudad])
    REFERENCES [dbo].[ciudad]
        ([idciudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciudadcliente'
CREATE INDEX [IX_fk_ciudadcliente]
ON [dbo].[cliente]
    ([idciudad]);
GO

-- Creating foreign key on [idciudad] in table 'maenits'
ALTER TABLE [dbo].[maenits]
ADD CONSTRAINT [fk_ciudadnits]
    FOREIGN KEY ([idciudad])
    REFERENCES [dbo].[ciudad]
        ([idciudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciudadnits'
CREATE INDEX [IX_fk_ciudadnits]
ON [dbo].[maenits]
    ([idciudad]);
GO

-- Creating foreign key on [idciudad] in table 'sucursal'
ALTER TABLE [dbo].[sucursal]
ADD CONSTRAINT [fk_ciudadsucursal]
    FOREIGN KEY ([idciudad])
    REFERENCES [dbo].[ciudad]
        ([idciudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciudadsucursal'
CREATE INDEX [IX_fk_ciudadsucursal]
ON [dbo].[sucursal]
    ([idciudad]);
GO

-- Creating foreign key on [codigodepto] in table 'ciudad'
ALTER TABLE [dbo].[ciudad]
ADD CONSTRAINT [fk_deptociudad]
    FOREIGN KEY ([codigodepto])
    REFERENCES [dbo].[departamento]
        ([iddept])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_deptociudad'
CREATE INDEX [IX_fk_deptociudad]
ON [dbo].[ciudad]
    ([codigodepto]);
GO

-- Creating foreign key on [idcliente] in table 'maecli'
ALTER TABLE [dbo].[maecli]
ADD CONSTRAINT [fk_clientedatoscliente]
    FOREIGN KEY ([idcliente])
    REFERENCES [dbo].[cliente]
        ([idcliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_clientedatoscliente'
CREATE INDEX [IX_fk_clientedatoscliente]
ON [dbo].[maecli]
    ([idcliente]);
GO

-- Creating foreign key on [idtipodto] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [fk_tipodtocliente]
    FOREIGN KEY ([idtipodto])
    REFERENCES [dbo].[tiponit]
        ([idtiponit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_tipodtocliente'
CREATE INDEX [IX_fk_tipodtocliente]
ON [dbo].[cliente]
    ([idtipodto]);
GO

-- Creating foreign key on [idcompania] in table 'sucursal'
ALTER TABLE [dbo].[sucursal]
ADD CONSTRAINT [fk_ciasucursal]
    FOREIGN KEY ([idcompania])
    REFERENCES [dbo].[compania]
        ([idcompania])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciasucursal'
CREATE INDEX [IX_fk_ciasucursal]
ON [dbo].[sucursal]
    ([idcompania]);
GO

-- Creating foreign key on [idcompania] in table 'conexuser'
ALTER TABLE [dbo].[conexuser]
ADD CONSTRAINT [fk_usercia]
    FOREIGN KEY ([idcompania])
    REFERENCES [dbo].[compania]
        ([idcompania])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_usercia'
CREATE INDEX [IX_fk_usercia]
ON [dbo].[conexuser]
    ([idcompania]);
GO

-- Creating foreign key on [codigcomprob] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_compromovimi]
    FOREIGN KEY ([codigcomprob])
    REFERENCES [dbo].[comprobante]
        ([codigcomprob])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_compromovimi'
CREATE INDEX [IX_fk_compromovimi]
ON [dbo].[movimi]
    ([codigcomprob]);
GO

-- Creating foreign key on [codigcomp] in table 'maetrac'
ALTER TABLE [dbo].[maetrac]
ADD CONSTRAINT [fk_comprtrac]
    FOREIGN KEY ([codigcomp])
    REFERENCES [dbo].[comprobante]
        ([codigcomprob])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_comprtrac'
CREATE INDEX [IX_fk_comprtrac]
ON [dbo].[maetrac]
    ([codigcomp]);
GO

-- Creating foreign key on [idusuario] in table 'conexuser'
ALTER TABLE [dbo].[conexuser]
ADD CONSTRAINT [fk_userconex]
    FOREIGN KEY ([idusuario])
    REFERENCES [dbo].[usuario]
        ([idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_userconex'
CREATE INDEX [IX_fk_userconex]
ON [dbo].[conexuser]
    ([idusuario]);
GO

-- Creating foreign key on [idusuariodatos] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [fk_usuario]
    FOREIGN KEY ([idusuariodatos])
    REFERENCES [dbo].[datosusuario]
        ([idusuariodat])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_usuario'
CREATE INDEX [IX_fk_usuario]
ON [dbo].[usuario]
    ([idusuariodatos]);
GO

-- Creating foreign key on [idpais] in table 'departamento'
ALTER TABLE [dbo].[departamento]
ADD CONSTRAINT [fk_paisdept]
    FOREIGN KEY ([idpais])
    REFERENCES [dbo].[pais]
        ([idpais])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_paisdept'
CREATE INDEX [IX_fk_paisdept]
ON [dbo].[departamento]
    ([idpais]);
GO

-- Creating foreign key on [codigotipo] in table 'formato'
ALTER TABLE [dbo].[formato]
ADD CONSTRAINT [fk_tipoformato]
    FOREIGN KEY ([codigotipo])
    REFERENCES [dbo].[tipoformato]
        ([codigotipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_tipoformato'
CREATE INDEX [IX_fk_tipoformato]
ON [dbo].[formato]
    ([codigotipo]);
GO

-- Creating foreign key on [codformatomedios] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [fk_formatomedioscuenta]
    FOREIGN KEY ([codformatomedios])
    REFERENCES [dbo].[formatomedios]
        ([idformatomedios])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_formatomedioscuenta'
CREATE INDEX [IX_fk_formatomedioscuenta]
ON [dbo].[maeconta]
    ([codformatomedios]);
GO

-- Creating foreign key on [cuentafin] in table 'formatosbpyg'
ALTER TABLE [dbo].[formatosbpyg]
ADD CONSTRAINT [fk_cuentafinforbpyg]
    FOREIGN KEY ([cuentafin])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentafinforbpyg'
CREATE INDEX [IX_fk_cuentafinforbpyg]
ON [dbo].[formatosbpyg]
    ([cuentafin]);
GO

-- Creating foreign key on [cuentaini] in table 'formatosbpyg'
ALTER TABLE [dbo].[formatosbpyg]
ADD CONSTRAINT [fk_cuentainifombpyg]
    FOREIGN KEY ([cuentaini])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentainifombpyg'
CREATE INDEX [IX_fk_cuentainifombpyg]
ON [dbo].[formatosbpyg]
    ([cuentaini]);
GO

-- Creating foreign key on [idsucursal] in table 'inflacion'
ALTER TABLE [dbo].[inflacion]
ADD CONSTRAINT [fk_sucursalinfla]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_sucursalinfla'
CREATE INDEX [IX_fk_sucursalinfla]
ON [dbo].[inflacion]
    ([idsucursal]);
GO

-- Creating foreign key on [cuenta] in table 'maecli'
ALTER TABLE [dbo].[maecli]
ADD CONSTRAINT [fk_cuentamaecli]
    FOREIGN KEY ([cuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentamaecli'
CREATE INDEX [IX_fk_cuentamaecli]
ON [dbo].[maecli]
    ([cuenta]);
GO

-- Creating foreign key on [idvendedor] in table 'maecli'
ALTER TABLE [dbo].[maecli]
ADD CONSTRAINT [fk_vendedorcliente]
    FOREIGN KEY ([idvendedor])
    REFERENCES [dbo].[vendedor]
        ([idvendedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_vendedorcliente'
CREATE INDEX [IX_fk_vendedorcliente]
ON [dbo].[maecli]
    ([idvendedor]);
GO

-- Creating foreign key on [cueaju] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [fk_cuentacueaju]
    FOREIGN KEY ([cueaju])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentacueaju'
CREATE INDEX [IX_fk_cuentacueaju]
ON [dbo].[maeconta]
    ([cueaju]);
GO

-- Creating foreign key on [cuentacierre] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [fk_cuentacuecierre]
    FOREIGN KEY ([cuentacierre])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentacuecierre'
CREATE INDEX [IX_fk_cuentacuecierre]
ON [dbo].[maeconta]
    ([cuentacierre]);
GO

-- Creating foreign key on [cuencorre] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [fk_cuentacuecor]
    FOREIGN KEY ([cuencorre])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentacuecor'
CREATE INDEX [IX_fk_cuentacuecor]
ON [dbo].[maeconta]
    ([cuencorre]);
GO

-- Creating foreign key on [cuenta] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_cuentamovimi]
    FOREIGN KEY ([cuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentamovimi'
CREATE INDEX [IX_fk_cuentamovimi]
ON [dbo].[movimi]
    ([cuenta]);
GO

-- Creating foreign key on [cuenta] in table 'maepagos'
ALTER TABLE [dbo].[maepagos]
ADD CONSTRAINT [fk_cuentapagos]
    FOREIGN KEY ([cuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentapagos'
CREATE INDEX [IX_fk_cuentapagos]
ON [dbo].[maepagos]
    ([cuenta]);
GO

-- Creating foreign key on [cuenta] in table 'presupuesto'
ALTER TABLE [dbo].[presupuesto]
ADD CONSTRAINT [fk_cuentapresupuesto]
    FOREIGN KEY ([cuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentapresupuesto'
CREATE INDEX [IX_fk_cuentapresupuesto]
ON [dbo].[presupuesto]
    ([cuenta]);
GO

-- Creating foreign key on [cuenta] in table 'saldoscuentas'
ALTER TABLE [dbo].[saldoscuentas]
ADD CONSTRAINT [fk_cuentasaldos]
    FOREIGN KEY ([cuenta])
    REFERENCES [dbo].[maeconta]
        ([idcuenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_cuentasaldos'
CREATE INDEX [IX_fk_cuentasaldos]
ON [dbo].[saldoscuentas]
    ([cuenta]);
GO

-- Creating foreign key on [idnitajustes] in table 'maeconta'
ALTER TABLE [dbo].[maeconta]
ADD CONSTRAINT [fk_nitcuenta]
    FOREIGN KEY ([idnitajustes])
    REFERENCES [dbo].[maenits]
        ([idnit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_nitcuenta'
CREATE INDEX [IX_fk_nitcuenta]
ON [dbo].[maeconta]
    ([idnitajustes]);
GO

-- Creating foreign key on [idnit] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_nitmovimi]
    FOREIGN KEY ([idnit])
    REFERENCES [dbo].[maenits]
        ([idnit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_nitmovimi'
CREATE INDEX [IX_fk_nitmovimi]
ON [dbo].[movimi]
    ([idnit]);
GO

-- Creating foreign key on [idnit] in table 'maepagos'
ALTER TABLE [dbo].[maepagos]
ADD CONSTRAINT [fk_nitpagos]
    FOREIGN KEY ([idnit])
    REFERENCES [dbo].[maenits]
        ([idnit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_nitpagos'
CREATE INDEX [IX_fk_nitpagos]
ON [dbo].[maepagos]
    ([idnit]);
GO

-- Creating foreign key on [idnittope] in table 'maetribut'
ALTER TABLE [dbo].[maetribut]
ADD CONSTRAINT [fk_nittrib]
    FOREIGN KEY ([idnittope])
    REFERENCES [dbo].[maenits]
        ([idnit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_nittrib'
CREATE INDEX [IX_fk_nittrib]
ON [dbo].[maetribut]
    ([idnittope]);
GO

-- Creating foreign key on [idtiponit] in table 'maenits'
ALTER TABLE [dbo].[maenits]
ADD CONSTRAINT [fk_tiponitnits]
    FOREIGN KEY ([idtiponit])
    REFERENCES [dbo].[tiponit]
        ([idtiponit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_tiponitnits'
CREATE INDEX [IX_fk_tiponitnits]
ON [dbo].[maenits]
    ([idtiponit]);
GO

-- Creating foreign key on [idsucursal] in table 'maepagos'
ALTER TABLE [dbo].[maepagos]
ADD CONSTRAINT [fk_ciapagos]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciapagos'
CREATE INDEX [IX_fk_ciapagos]
ON [dbo].[maepagos]
    ([idsucursal]);
GO

-- Creating foreign key on [idmoduloppal] in table 'maetrac'
ALTER TABLE [dbo].[maetrac]
ADD CONSTRAINT [fk_modulotrac]
    FOREIGN KEY ([idmoduloppal])
    REFERENCES [dbo].[moduloppal]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_modulotrac'
CREATE INDEX [IX_fk_modulotrac]
ON [dbo].[maetrac]
    ([idmoduloppal]);
GO

-- Creating foreign key on [idtipodocumento] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_tipodocmovimi]
    FOREIGN KEY ([idtipodocumento])
    REFERENCES [dbo].[maetrac]
        ([idtransaccion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_tipodocmovimi'
CREATE INDEX [IX_fk_tipodocmovimi]
ON [dbo].[movimi]
    ([idtipodocumento]);
GO

-- Creating foreign key on [idmoduloppal] in table 'modulo'
ALTER TABLE [dbo].[modulo]
ADD CONSTRAINT [fk_moduloppalmodulo]
    FOREIGN KEY ([idmoduloppal])
    REFERENCES [dbo].[moduloppal]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_moduloppalmodulo'
CREATE INDEX [IX_fk_moduloppalmodulo]
ON [dbo].[modulo]
    ([idmoduloppal]);
GO

-- Creating foreign key on [idmodulo] in table 'permiso'
ALTER TABLE [dbo].[permiso]
ADD CONSTRAINT [fk_permmod]
    FOREIGN KEY ([idmodulo])
    REFERENCES [dbo].[modulo]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_permmod'
CREATE INDEX [IX_fk_permmod]
ON [dbo].[permiso]
    ([idmodulo]);
GO

-- Creating foreign key on [idmoduloimprime] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_modulomovimi]
    FOREIGN KEY ([idmoduloimprime])
    REFERENCES [dbo].[moduloppal]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_modulomovimi'
CREATE INDEX [IX_fk_modulomovimi]
ON [dbo].[movimi]
    ([idmoduloimprime]);
GO

-- Creating foreign key on [idmoduloppal] in table 'parametro'
ALTER TABLE [dbo].[parametro]
ADD CONSTRAINT [fk_moduloparametro]
    FOREIGN KEY ([idmoduloppal])
    REFERENCES [dbo].[moduloppal]
        ([idmodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_moduloparametro'
CREATE INDEX [IX_fk_moduloparametro]
ON [dbo].[parametro]
    ([idmoduloppal]);
GO

-- Creating foreign key on [idsucursal] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_ciamovimi]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciamovimi'
CREATE INDEX [IX_fk_ciamovimi]
ON [dbo].[movimi]
    ([idsucursal]);
GO

-- Creating foreign key on [idusuarioact] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_usuarioactmovimi]
    FOREIGN KEY ([idusuarioact])
    REFERENCES [dbo].[usuario]
        ([idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_usuarioactmovimi'
CREATE INDEX [IX_fk_usuarioactmovimi]
ON [dbo].[movimi]
    ([idusuarioact]);
GO

-- Creating foreign key on [idusuario] in table 'movimi'
ALTER TABLE [dbo].[movimi]
ADD CONSTRAINT [fk_usuariomovimi]
    FOREIGN KEY ([idusuario])
    REFERENCES [dbo].[usuario]
        ([idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_usuariomovimi'
CREATE INDEX [IX_fk_usuariomovimi]
ON [dbo].[movimi]
    ([idusuario]);
GO

-- Creating foreign key on [idusuario] in table 'permiso'
ALTER TABLE [dbo].[permiso]
ADD CONSTRAINT [fk_userperm]
    FOREIGN KEY ([idusuario])
    REFERENCES [dbo].[usuario]
        ([idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_userperm'
CREATE INDEX [IX_fk_userperm]
ON [dbo].[permiso]
    ([idusuario]);
GO

-- Creating foreign key on [idsucursal] in table 'presupuesto'
ALTER TABLE [dbo].[presupuesto]
ADD CONSTRAINT [fk_ciapresupuesto]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciapresupuesto'
CREATE INDEX [IX_fk_ciapresupuesto]
ON [dbo].[presupuesto]
    ([idsucursal]);
GO

-- Creating foreign key on [idsucursal] in table 'saldoscuentas'
ALTER TABLE [dbo].[saldoscuentas]
ADD CONSTRAINT [fk_sucursalsaldos]
    FOREIGN KEY ([idsucursal])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_sucursalsaldos'
CREATE INDEX [IX_fk_sucursalsaldos]
ON [dbo].[saldoscuentas]
    ([idsucursal]);
GO

-- Creating foreign key on [idcompania] in table 'usuariocia'
ALTER TABLE [dbo].[usuariocia]
ADD CONSTRAINT [fk_ciausxcia]
    FOREIGN KEY ([idcompania])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_ciausxcia'
CREATE INDEX [IX_fk_ciausxcia]
ON [dbo].[usuariocia]
    ([idcompania]);
GO

-- Creating foreign key on [idcompania] in table 'vendedor'
ALTER TABLE [dbo].[vendedor]
ADD CONSTRAINT [fk_sucursalvendedor]
    FOREIGN KEY ([idcompania])
    REFERENCES [dbo].[sucursal]
        ([idsucursal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_sucursalvendedor'
CREATE INDEX [IX_fk_sucursalvendedor]
ON [dbo].[vendedor]
    ([idcompania]);
GO

-- Creating foreign key on [idusuario] in table 'usuariocia'
ALTER TABLE [dbo].[usuariocia]
ADD CONSTRAINT [fk_userusxcia]
    FOREIGN KEY ([idusuario])
    REFERENCES [dbo].[usuario]
        ([idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'fk_userusxcia'
CREATE INDEX [IX_fk_userusxcia]
ON [dbo].[usuariocia]
    ([idusuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------