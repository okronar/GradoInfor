package com.sergio.aplicacionpmdm.BoardGamesApp

import android.view.View
import android.widget.TextView
import androidx.core.content.ContextCompat.getColor
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.R

class CategoriesViewHolder (view: View): RecyclerView.ViewHolder(view){
    private val tvCategoryName: TextView = view.findViewById(R.id.tvCategoryName)
    private val divider: View = view.findViewById(R.id.divider)

//    este metodo pinta las categorias que le pases
    fun render(gameCategory: GameCategory){
        when(gameCategory){
            GameCategory.Cooperative -> {
                tvCategoryName.text = "Cooperativos"
                divider.setBackgroundColor(getColor(divider.context, R.color.bgapp_cooperative_category))
            }
            GameCategory.Deckbuilding -> {
                tvCategoryName.text = "Deckbuilding"
                divider.setBackgroundColor(getColor(divider.context, R.color.bgapp_deckbuilding_category))
            }

            GameCategory.Euro -> {
                tvCategoryName.text = "EuroGames"
                divider.setBackgroundColor(getColor(divider.context, R.color.bgapp_euro_category))
            }
            GameCategory.LCG -> {
                tvCategoryName.text = "Living Card Games"
                divider.setBackgroundColor(getColor(divider.context, R.color.bgapp_lcg_category))
            }
            GameCategory.Legacy -> {
                tvCategoryName.text = "Legacy"
                divider.setBackgroundColor(getColor(divider.context, R.color.bgapp_legacy_category))
            }
        }
    }


}