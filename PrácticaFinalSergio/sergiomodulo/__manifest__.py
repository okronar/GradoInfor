# -*- coding: utf-8 -*-
{
    'name': "sergiomodulo",

    'summary': """
        modulo de sergio para odoo16""",

    'description': """
        modulo de sergio para odoo16 con cosillas varias
    """,

    'author': "Sergio",
    'website': "http://127.0.0.1:8069/web?db=empresilla#action=120&cids=1&menu_id=82",

    # Categories can be used to filter modules in modules listing
    # Check https://github.com/odoo/odoo/blob/16.0/odoo/addons/base/data/ir_module_category_data.xml
    # for the full list
    'category': 'Uncategorized',
    'version': '0.1',

    # any module necessary for this one to work correctly
    'depends': ['base'],

    # always loaded
    'installable': True,
    'application': True,
    'data': [
        'security/ir.model.access.csv',
        'views/views.xml',
        'views/templates.xml',
    ],
    # only loaded in demonstration mode<
    'demo': [
        'demo/demo.xml',
    ],
}
