package com.sergio.room_database.data.network

import com.sergio.room_database.core.RetrofitHelper
import com.sergio.room_database.data.model.QuoteModel
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.withContext

class QuoteService {


    private val retrofit = RetrofitHelper.getRetrofit()
    suspend fun getQuotes(): List<QuoteModel> {
        return withContext(Dispatchers.IO) {
            val response = retrofit.create(QuoteApiClient::class.java).getAllQuotes()
            response.body() ?: emptyList()
        }
    }}