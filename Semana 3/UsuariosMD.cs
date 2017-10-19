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

public class UsuariosMD {
	
	
    public UsuariosMD(){}
    
    public void ingresarUsuarios(Usuarios nuevo){
    
	private SQLiteConnection con;
	
	try {
    con = new SQLiteConnection("Data Source=data.db");
    con.Open();
	
	string cadenaSQL = "insert into Usuario(NICKNAME,NOMBREUSUARIO,PASSWORD) values('"+nuevo.getNickname()+"',"+nuevo.getNombreUsuario+","+nuevo.getPassword()+");";
	
	SQLiteCommand command = new SQLiteCommand(cadenaSQL, con);
	command.ExecuteNonQuery();
	command.Dispose();
	} catch(SQLiteException ex) {
    MessageBox.show(ex.Message);
	}
	
    }
    
    
    
    public Object[] buscarPropietario(String dato){
    String busqueda="";
    ArrayList<Object> almacenamiento=new ArrayList<Object>();
        if (!dato.equals("")) {
            busqueda="where cedulap='"+dato+"'";
        }
		
	private SQLiteConnection con;
	
	try {
    con = new SQLiteConnection("Data Source=data.db");
    con.Open();
	
	DataSet ds = new DataSet();

    SQLiteDataAdapter da = new SQLiteDataAdapter("select id,nombre,telefono,edad from Usuarios "+busqueda+";", con);
	
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