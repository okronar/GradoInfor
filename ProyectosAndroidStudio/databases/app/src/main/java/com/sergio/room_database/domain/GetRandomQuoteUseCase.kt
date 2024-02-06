package com.sergio.room_database.domain

import com.sergio.room_database.data.QuoteRepository
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import javax.inject.Inject

class GetRandomQuoteUseCase @Inject constructor(private val repository : QuoteRepository){


    //Ahora no necesita una corrutina porque lo tenemos almacenado en QuoteProvider
    operator fun invoke(): QuoteModel? {
        val quotes = QuoteProvider.quotes
        if (!quotes.isNullOrEmpty()) {
            val randomNumber = (quotes.indices).random()
            return quotes[randomNumber]
        }
        return null  /*No hace falta incluir else*/   }   }
