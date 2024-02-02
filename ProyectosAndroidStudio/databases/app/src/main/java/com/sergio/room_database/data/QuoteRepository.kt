package com.sergio.room_database.data

import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.data.network.QuoteService

class QuoteRepository {

    private val api = QuoteService()

    suspend fun getAllQuotes():List<QuoteModel>{
        val response:List<QuoteModel> = api.getQuotes()
        QuoteProvider.quotes = response
        return response
    }
}

