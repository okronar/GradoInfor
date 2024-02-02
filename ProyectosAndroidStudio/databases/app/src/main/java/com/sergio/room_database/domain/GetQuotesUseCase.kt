package com.sergio.room_database.domain

import com.sergio.room_database.data.QuoteRepository
import com.sergio.room_database.data.model.QuoteModel

class GetQuotesUseCase {
    private val repository = QuoteRepository()
    //suspend es por corrutina
    suspend operator fun invoke():List<QuoteModel>{
    return repository.getAllQuotes()
    }
}
