# -*- coding: utf-8 -*-

from odoo import models, fields, api

class webinar_DAMDSRT(models.Models):

    _name = 'webinarCurso'
    
    Nombre  = fields.Char(string = 'Nombre',required=True,help = "Nombre de Curso")
    Descripcion = fields.Text(string = "Descripcion")
    Horas =  fields.Integer(string="Horas")
    Fecha = fields.Date(string = "Fecha")
    Lugar  = fields.Char(string = "Lugar")
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
