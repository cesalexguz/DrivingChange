/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     18/10/2017 10:18:55                          */
/*==============================================================*/


drop table if exists CALIFICACIONES;

drop table if exists TIENE;

drop table if exists USUARIO;

/*==============================================================*/
/* Table: CALIFICACIONES                                        */
/*==============================================================*/
create table CALIFICACIONES
(
   ID                   int not null auto_increment,
   PUNTAJES             int,
   primary key (ID)
)
type = InnoDB;

/*==============================================================*/
/* Table: TIENE                                                 */
/*==============================================================*/
create table TIENE
(
   ID                   int not null,
   NICKNAME             char(50) not null,
   primary key (ID, NICKNAME)
)
type = InnoDB;

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   NICKNAME             char(50) not null,
   NOMBREUSUARIO        char(50) not null,
   PASSWORD             char(40),
   primary key (NICKNAME)
)
type = InnoDB;

alter table TIENE add constraint FK_TIENE foreign key (ID)
      references CALIFICACIONES (ID) on delete restrict on update restrict;

alter table TIENE add constraint FK_TIENE foreign key (NICKNAME)
      references USUARIO (NICKNAME) on delete restrict on update restrict;

