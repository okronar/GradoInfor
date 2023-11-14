package com.sergio.aplicacionpmdm.Tarea1

import android.view.View
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.core.content.ContextCompat.getColor
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.R

class VerticalViewHolder (view: View) : RecyclerView.ViewHolder(view) {
    private var tvVertical: TextView =
        view.findViewById(R.id.textVerticalItem)
    private var cvVertical: CardView =
        view.findViewById(R.id.VerticalItem)

    fun pintarViews(item: VerticalObject){
        tvVertical.text = item.texto
        //tvVertical.setTextColor(item.colorFcondo)
        cvVertical.setCardBackgroundColor(item.colorFondo)
    }


}

