package com.sergio.gamesapitrabajo

import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Query

interface ApiService {

    @GET("games?key=c63c86bef12e45d8ba1661ac84e539a1")
    suspend fun getVideoGames(@Query("search") videoGameName:String): Response<VideoGamesDataResponse>

}