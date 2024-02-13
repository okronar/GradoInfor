package com.sergio.tarea3sergio

import com.sergio.tarea3sergio.SuperHeroDataResponse
import com.sergio.tarea3sergio.SuperHeroDetailResponse
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Path

interface ApiService {
    //aqui definimos las busquedas en la API
//todas las funciones con corrutinas deben tener suspend
    @GET("search/{name}")
    suspend fun getSuperheroes(@Path("name") superheroName:String): Response<SuperHeroDataResponse>

    @GET("{id}")
   suspend fun getSuperheroDetail(@Path("id") superheroId:String):Response<SuperHeroDetailResponse>


}