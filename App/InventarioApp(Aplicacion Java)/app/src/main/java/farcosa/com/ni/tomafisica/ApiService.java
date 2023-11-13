package farcosa.com.ni.tomafisica;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface ApiService {

   @POST("api/Articulo/")
   Call<ApiRequest> saveArticulos(@Body ApiResponse apiResponse);

}
