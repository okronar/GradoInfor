package com.sergio.aplicacionpmdm.BoardGamesApp

import android.view.View
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.core.content.ContextCompat
import androidx.core.content.ContextCompat.getColor
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.R

class CategoriesViewHolder (view: View): RecyclerView.ViewHolder(view){
    private val tvCategoryName: TextView = view.findViewById(R.id.tvCategoryName)
    private val divider: View = view.findViewById(R.id.divider)
    private val viewContainer: CardView = view.findViewById(R.id.viewContainer)



//    este metodo pinta las categorias que le pases
    fun render(gameCategory: GameCategory, onCategorySelected:(Int) -> Unit){
    val color = if (gameCategory.isSelected) {
        R.color.bgapp_background_card
    } else {
        R.color.bgapp_background_disabled
    }

    viewContainer.setCardBackgroundColor(ContextCompat.getColor(viewContainer.context, color))

    itemView.setOnClickListener { onCategorySelected(layoutPosition) }

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