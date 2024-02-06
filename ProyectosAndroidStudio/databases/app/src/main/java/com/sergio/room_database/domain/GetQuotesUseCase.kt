package com.sergio.room_database.domain

import com.sergio.room_database.data.QuoteRepository
import com.sergio.room_database.data.model.QuoteModel
import javax.inject.Inject

class GetQuotesUseCase @Inject constructor(private val repository : QuoteRepository) {

    //suspend es por corrutina
    suspend operator fun invoke():List<QuoteModel>{
    return repository.getAllQuotes()
    }
}
