package com.sergio.aplicacionpmdm.Tarea1

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.R


class VerticalAdapter (private val listaVerticales: List<VerticalObject>) : RecyclerView.Adapter<VerticalViewHolder> () {
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VerticalViewHolder {
        val view =
            LayoutInflater.from(parent.context).inflate(R.layout.verticalitem, parent, false)
        return VerticalViewHolder(view)
    }

    override fun getItemCount(): Int {
        return listaVerticales.size
    }

    override fun onBindViewHolder(holder: VerticalViewHolder, position: Int) {
        holder.pintarViews(listaVerticales[position])
    }


}


