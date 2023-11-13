package farcosa.com.ni.tomafisica;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ScrollView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.Calendar;
import java.util.HashMap;
import java.util.Map;

public class MainActivity extends AppCompatActivity {

    //Instancias
    //login
    /*private EditText mEditTextName;
    private EditText mEditTextEmail;
    private EditText mEditTextPassword;*/

    EditText txtCodigo,txtDescripcion,txtLote,txtCantidad,txtBodega,txtConteo,txtVencimiento,txtProveedor,txtTipo,txtUm;
    Button btnGuardar, btnBuscar,btnCancelar;
    TextView txtUbicaciones, txtbo,txtco, txtracks,txtUsuarios, txtUserAutoCompleteTextView2;
    AutoCompleteTextView txtUserAutoCompleteTextView;
    Spinner spinenerUbicacion;
    RequestQueue requestQueue;
    //Date Picker dialog
    DatePickerDialog.OnDateSetListener onDateSetListener;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        /*mEditTextName = (EditText) findViewById(R.id.editTextName);
        mEditTextEmail = (EditText) findViewById(R.id.editTextEmail);
        mEditTextPassword = (EditText) findViewById(R.id.editTextPassword);*/

        //Strigs De Recursos para autocompleteTexview de ubicaciones
        AutoCompleteTextView editText = findViewById(R.id.actv);
        txtUbicaciones = findViewById(R.id.txt_view_Ubicaciones);
        ArrayAdapter<CharSequence> adaptador = ArrayAdapter.
                createFromResource(this, R.array.ubicaciones,
                        android.R.layout.simple_list_item_1);
        editText.setAdapter(adaptador);
        editText.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtUbicaciones.setText(parent.getItemAtPosition(position).toString());
            }
        });
        //Strigs De Recursos para autocompleteTexview de Bodegas
        txtbo = findViewById(R.id.txt_view_bodegas);
        AutoCompleteTextView bo = findViewById(R.id.txtBodega);
        ArrayAdapter<CharSequence> adaptadorBodegas = ArrayAdapter.
                createFromResource(this, R.array.bodegas,
                        android.R.layout.simple_list_item_1);
        bo.setAdapter(adaptadorBodegas);
        bo.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtbo.setText(parent.getItemAtPosition(position).toString());
            }
        });

        //Strigs De Recursos para autocompleteTexview de conteos
        txtco = findViewById(R.id.txt_view_conteos);
        AutoCompleteTextView conteos = findViewById(R.id.txtConteo);
        ArrayAdapter<CharSequence> adaptadorConteos = ArrayAdapter.
                createFromResource(this, R.array.conteos,
                        android.R.layout.simple_list_item_1);
        conteos.setAdapter(adaptadorConteos);
        conteos.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtco.setText(parent.getItemAtPosition(position).toString());
            }
        });

        //Strigs De Recursos para autocompleteTexview de conteos
        txtracks = findViewById(R.id.txt_view_rack);
        AutoCompleteTextView racks = findViewById(R.id.rack);
        ArrayAdapter<CharSequence> adaptadorRacks = ArrayAdapter.
                createFromResource(this, R.array.racks,
                        android.R.layout.simple_list_item_1);
        racks.setAdapter(adaptadorRacks);
        racks.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtracks.setText(parent.getItemAtPosition(position).toString());
            }
        });


        //Strigs De Recursos para autocompleteTexview de usuarios
        txtUsuarios = findViewById(R.id.txt_view_users);
        AutoCompleteTextView usuarios = findViewById(R.id.txtUser);
        ArrayAdapter<CharSequence> adaptadorUsers = ArrayAdapter.
                createFromResource(this, R.array.usuarios,
                        android.R.layout.simple_list_item_1);
        usuarios.setAdapter(adaptadorUsers);
        usuarios.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtUsuarios.setText(parent.getItemAtPosition(position).toString());
            }
        });

        //VARIABLES CALENDAR
        final Calendar calendar = Calendar.getInstance();
        int year = calendar.get(Calendar.YEAR);
        int month = calendar.get(Calendar.MONTH);
        int day = calendar.get(Calendar.DAY_OF_MONTH);
        //INSTANCIANDO COMPONENTES XML
        txtUserAutoCompleteTextView = (AutoCompleteTextView) findViewById(R.id.txtUser);
        txtUserAutoCompleteTextView2 = (TextView) findViewById(R.id.txt_view_users);
        txtCodigo = (EditText) findViewById(R.id.txtCodigo);
        txtDescripcion = (EditText)findViewById(R.id.txtDescripcion);
        txtDescripcion.setEnabled(false);
        txtLote = (EditText)findViewById(R.id.txtLote);
        //txtLote.setEnabled(false);
        txtCantidad = (EditText)findViewById(R.id.txtCantidad);
        txtBodega = (EditText)findViewById(R.id.txtBodega);
        txtConteo = (EditText)findViewById(R.id.txtConteo);
        txtVencimiento = (EditText)findViewById(R.id.txtVencimiento);
        //txtVencimiento.setEnabled(false);
        txtProveedor = (EditText)findViewById(R.id.txtProveedor);
        txtTipo = (EditText)findViewById(R.id.txtTipo);
        txtUm = (EditText)findViewById(R.id.txtum);
        btnGuardar = (Button) findViewById(R.id.btnGuardar);
        btnBuscar = (Button) findViewById(R.id.btnBuscar);
        btnCancelar = (Button) findViewById(R.id.btnLimpiarCampos);
        txtVencimiento.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DatePickerDialog datePickerDialog = new DatePickerDialog(
                        MainActivity.this, android.R.style.Theme_Holo_Light_Dialog_MinWidth,
                        onDateSetListener,year,month,day);
                datePickerDialog.getWindow().setBackgroundDrawable(new ColorDrawable(Color.TRANSPARENT));
                datePickerDialog.show();
            }
        });
        onDateSetListener = new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker view, int year, int month, int dayOfMonth) {
                month = month + 1;
                /*String date = dayOfMonth+"-"+month+"-"+year;*/
                String date = year+"-"+month+"-"+dayOfMonth; //aca va
                txtVencimiento.setText(date);
            }
        };

        btnGuardar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ejecutarServicio("http://192.95.21.165:8081/api/Articulo/");
                dbutton();
                //ejecutarServicio("http://192.168.1.7:9095/api/Inventa");
            }
        });
        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                buscarProducto("http://192.95.21.165:8081/api/Articulo/"+txtCodigo.getText()+"");
                //buscarProducto("http://192.168.0.9:9095/api/Inventa/"+txtCodigo.getText()+"");
            }
        });
        btnCancelar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                hbutton();
                editText.setText("");
                conteos.setText("");
                bo.setText("");
                racks.setText("");
                usuarios.setText("");
                clear();
            }
        });

    }

    //ENVIAR POST
    private void ejecutarServicio(String URL){
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL, new Response.Listener<String>() {
            @Override
           public void onResponse(String response) {
                Toast.makeText(getApplicationContext(), "Registro Ingresado", Toast.LENGTH_SHORT).show();
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
              Toast.makeText(getApplicationContext(), error.toString(), Toast.LENGTH_SHORT).show();
                Log.e("Volly Error", error.toString());
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                Map<String ,String> parametros = new HashMap<String, String>();
                parametros.put("conteo", txtco.getText().toString());
                parametros.put("bodega", txtbo.getText().toString());
                parametros.put("codigo", txtCodigo.getText().toString());
                parametros.put("lote", txtLote.getText().toString());
                parametros.put("fecha", txtVencimiento.getText().toString());
                parametros.put("descripcion", txtDescripcion.getText().toString());
                parametros.put("cantidad", txtCantidad.getText().toString());
                parametros.put("proveedor", txtProveedor.getText().toString());
                parametros.put("tipo", txtTipo.getText().toString());
                parametros.put("ubicacion", txtUbicaciones.getText().toString());
                parametros.put("rack", txtracks.getText().toString());
                parametros.put("um", txtUm.getText().toString());
                parametros.put("user", txtUsuarios.getText().toString());
                return parametros;
           }
        };
        requestQueue= Volley.newRequestQueue(this);
       requestQueue.add(stringRequest);
    }


    /*Metodo para buscar articulo Json(Objeto)*/
    private void buscarProducto(String URL)
    {
        StringRequest postResquest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                /*for (int i = 0; i < response.length(); i++)*/
                try {
                    JSONObject jsonObject = new JSONObject(response);
                    txtCodigo.setText(jsonObject.getString("ARTICULO"));
                    txtDescripcion.setText(jsonObject.getString("DESCRIPCION"));
                    txtProveedor.setText(jsonObject.getString("PROVEEDOR"));
                    txtTipo.setText(jsonObject.getString("TIPO"));
                    txtUm.setText(jsonObject.getString("UM"));

                } catch (JSONException e) {
                    e.printStackTrace();

                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
            }
        });
        Volley.newRequestQueue(this).add(postResquest);
    }
    //Metodo para scanear código de barra
    public void Onclick(View view) {
        if (view.getId() == R.id.btnScanner){
            new IntentIntegrator(this).initiateScan();
        }
    }

    //Llamar metodo result
    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        //llamar la informacion
        IntentResult result = IntentIntegrator.parseActivityResult(requestCode, resultCode,data);
        //obtener la informacion en un string
        String datos = result.getContents();
        txtCodigo.setText(datos);
    }
    //Metodo Clear
    private void clear(){
        txtco.setText("");
        txtCodigo.setText("");
        txtDescripcion.setText("");
        txtProveedor.setText("");
        txtTipo.setText("");
        txtUm.setText("");
        txtracks.setText("");
        txtbo.setText("");
        txtUbicaciones.setText("");
        txtLote.setText("");
        txtVencimiento.setText("");
        txtCantidad.setText("");
        txtCodigo.requestFocus();
        txtUsuarios.setText("");
    }
    //Deshabilitar boton guardar al presionar guardar
    private void dbutton(){
        btnGuardar.setEnabled(false);
    }
    //Habilitar boton guardar al presionar Nuevo
    private void hbutton(){
        btnGuardar.setEnabled(true);
    }

    //Validar que los autocomplete se llenen.
    private void validarAutocmplete(){
        Button btnGuardar = findViewById(R.id.btnGuardar);
        btnGuardar.setVisibility(View.INVISIBLE);

        if (txtUserAutoCompleteTextView.isSelected()){
            btnGuardar.setVisibility(View.VISIBLE);
        }
        else{
            btnGuardar.setVisibility(View.INVISIBLE);
        }

    }

}