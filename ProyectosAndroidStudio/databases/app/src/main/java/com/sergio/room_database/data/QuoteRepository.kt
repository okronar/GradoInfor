package com.sergio.room_database.data

import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.data.network.QuoteService
import javax.inject.Inject

class QuoteRepository @Inject constructor(private val api : QuoteService){


//siempre que haya corrutina hay que poner el suspend. cada vez que la app espere una respuesta externa tendremos que hacer una corrutina
    suspend fun getAllQuotes():List<QuoteModel>{
        val response:List<QuoteModel> = api.getQuotes()
        QuoteProvider.quotes = response
        return response
    }
}

