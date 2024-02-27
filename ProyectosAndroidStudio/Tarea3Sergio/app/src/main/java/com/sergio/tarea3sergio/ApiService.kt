package com.sergio.tarea3sergio


import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Path

interface ApiService {
    //aqui definimos las busquedas en la API
//todas las funciones con corrutinas deben tener suspend
    @GET("/api/122099224400128532/search/sp")
    suspend fun getSuperheroes(): Response<SuperHeroDataResponse>

    @GET("/api/122099224400128532/search/sp")
   suspend fun getSuperheroDetail():Response<SuperHeroDetailResponse>


}