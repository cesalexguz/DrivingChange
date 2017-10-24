
using SQLite.Net.Attributes;
using System;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Platform.WinRT;
using SQLiteExample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class CalificacionesMD {
	
	
    public CalificacionesMD(){}
    
    public void ingresarCalificaciones(Calificaciones nuevo){
    
	private SQLiteConnection con;
	
	try {
    con = new SQLiteConnection("Data Source=data.db");
    con.Open();
	
	string cadenaSQL = "insert into Calificaciones(puntajes) values('"+nuevo.puntajes()+");";
	
	SQLiteCommand command = new SQLiteCommand(cadenaSQL, con);
	command.ExecuteNonQuery();
	command.Dispose();
	} catch(SQLiteException ex) {
    MessageBox.show(ex.Message);
	}
	
    }
    
    
    
    public Object[] buscarCalificaciones(String dato){
    String busqueda="";
    ArrayList<Object> almacenamiento=new ArrayList<Object>();
        if (!dato.equals("")) {
            busqueda="where id='"+dato+"'";
        }
		
	private SQLiteConnection con;
	
	try {
    con = new SQLiteConnection("Data Source=data.db");
    con.Open();
	
	DataSet ds = new DataSet();

    SQLiteDataAdapter da = new SQLiteDataAdapter("select id from Calificaciones "+busqueda+";", con);
	
    da.Fill(ds);
	
	while (a.next()) {
                Usuarios n=new Usuarios();
                n.setNickname(a.getString(1));
                n.setNombreUsuario(a.getString(2));
                n.setPassword(a.getString(3));
                almacenamiento.add(n);
            }
	
	command.Dispose();
	} catch(SQLiteException ex) {
    MessageBox.show(ex.Message);
	}
	
	return almacenamiento.toArray();    
	}
    
}