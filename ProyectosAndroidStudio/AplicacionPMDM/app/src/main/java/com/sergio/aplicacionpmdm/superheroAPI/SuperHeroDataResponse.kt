package com.sergio.aplicacionpmdm.superheroAPI

import com.google.gson.annotations.SerializedName


//coge el tipo de repsuesta y la lista de resultados

data class SuperHeroDataResponse(
    @SerializedName("response") val response: String,
    @SerializedName("results") val superheroes: List<SuperheroItemResponse>
)
//con esto coge los elementos del json y los transforma en strings y otro objeto que creamos nosotros
data class SuperheroItemResponse(
    @SerializedName("id") val superheroId: String,
    @SerializedName("name") val name: String,
    @SerializedName("image") val superheroImage: SuperheroImageResponse
)
// con esto almacenamos la url como string
data class SuperheroImageResponse(@SerializedName("url") val url:String)
