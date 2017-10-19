/*==============================================================*/
/* DBMS name:      MySQL 4.0                                    */
/* Created on:     18/10/2017 10:20:27                          */
/*==============================================================*/


drop table if exists CALIFICACIONES;

drop index TIENE_FK2 on TIENE;

drop index TIENE_FK on TIENE;

drop table if exists TIENE;

drop table if exists USUARIO;

/*==============================================================*/
/* Table: CALIFICACIONES                                        */
/*==============================================================*/
create table CALIFICACIONES
(
   ID                             int                            not null AUTO_INCREMENT,
   PUNTAJES                       int,
   primary key (ID)
)
type = InnoDB;

/*==============================================================*/
/* Table: TIENE                                                 */
/*==============================================================*/
create table TIENE
(
   ID                             int                            not null,
   NICKNAME                       char(50)                       not null,
   primary key (ID, NICKNAME)
)
type = InnoDB;

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on TIENE
(
   NICKNAME
);

/*==============================================================*/
/* Index: TIENE_FK2                                             */
/*==============================================================*/
create index TIENE_FK2 on TIENE
(
   ID
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   NICKNAME                       char(50)                       not null,
   NOMBREUSUARIO                  char(50)                       not null,
   PASSWORD                       char(40),
   primary key (NICKNAME)
)
type = InnoDB;

alter table TIENE add constraint FK_TIENE foreign key (ID)
      references CALIFICACIONES (ID) on delete restrict on update restrict;

alter table TIENE add constraint FK_TIENE foreign key (NICKNAME)
      references USUARIO (NICKNAME) on delete restrict on update restrict;

