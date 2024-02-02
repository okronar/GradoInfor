package com.sergio.room_database.ui.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.domain.GetQuotesUseCase

class QuoteViewModel : ViewModel() {

    val quoteModel = MutableLiveData<QuoteModel>()
    val getQuotesUseCase = GetQuotesUseCase()

    fun randomQuote() {
        val currentQuote: QuoteModel = QuoteProvider.random()
        quoteModel.postValue(currentQuote)
    }
}
