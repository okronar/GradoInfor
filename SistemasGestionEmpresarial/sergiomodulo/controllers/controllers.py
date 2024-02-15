# -*- coding: utf-8 -*-
# from odoo import http


# class Sergiomodulo(http.Controller):
#     @http.route('/sergiomodulo/sergiomodulo', auth='public')
#     def index(self, **kw):
#         return "Hello, world"

#     @http.route('/sergiomodulo/sergiomodulo/objects', auth='public')
#     def list(self, **kw):
#         return http.request.render('sergiomodulo.listing', {
#             'root': '/sergiomodulo/sergiomodulo',
#             'objects': http.request.env['sergiomodulo.sergiomodulo'].search([]),
#         })

#     @http.route('/sergiomodulo/sergiomodulo/objects/<model("sergiomodulo.sergiomodulo"):obj>', auth='public')
#     def object(self, obj, **kw):
#         return http.request.render('sergiomodulo.object', {
#             'object': obj
#         })
