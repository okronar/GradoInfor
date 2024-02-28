# -*- coding: utf-8 -*-

from odoo import models, fields, api

class curso(models.Model):

    _name = 'sergiomodulo.curso'
    
    name = fields.Char(string = 'Nombre',required=True,help = "Nombre de Curso")
    Descripcion = fields.Text(string = "Descripcion")
    Horas =  fields.Integer(string="Horas")
    Fecha = fields.Date(string = "Fecha")
    Lugar = fields.Char(string = "Lugar")

class alumno(models.Model):

    _name = 'sergiomodulo.alumno'
    
    name = fields.Char(string = 'Nombre',required=True,help = "Nombre de alumno")
    Descripcion = fields.Text(string = "Descripcion")
    
    
# class sergiomodulo(models.Model):
#     _name = 'sergiomodulo.sergiomodulo'
#     _description = 'sergiomodulo.sergiomodulo'

#     name = fields.Char()
#     value = fields.Integer()
#     value2 = fields.Float(compute="_value_pc", store=True)
#     description = fields.Text()
#
#     @api.depends('value')
#     def _value_pc(self):
#         for record in self:
#             record.value2 = float(record.value) / 100
