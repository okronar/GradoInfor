package com.sergio.aplicacionpmdm.superheroAPI

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.appcompat.widget.SearchView
import com.sergio.aplicacionpmdm.R
import com.sergio.aplicacionpmdm.databinding.ActivitySuperheroListBinding

class superheroListActivity : AppCompatActivity() {

    private lateinit var binding: ActivitySuperheroListBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivitySuperheroListBinding.inflate(layoutInflater)
        setContentView(R.layout.activity_superhero_list)


        initUI()
    }

    private fun initUI() {
        binding.searchView.setOnQueryTextListener(object: SearchView.OnQueryTextListener
        {
            override fun onQueryTextSubmit(query: String?): Boolean {
                searchByName(query.orEmpty())
                return false
            }

            override fun onQueryTextChange(newText: String?) = false

        })

    }

    private fun searchByName(query: String?) {

    }
}