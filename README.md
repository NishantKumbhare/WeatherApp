{\rtf1\ansi\ansicpg1252\cocoartf1504\cocoasubrtf830
{\fonttbl\f0\fswiss\fcharset204 Helvetica;\f1\fnil\fcharset0 Menlo-Regular;\f2\fnil\fcharset0 Consolas;
}
{\colortbl;\red255\green255\blue255;\red0\green0\blue0;\red238\green238\blue236;\red27\green31\blue34;
\red244\green246\blue249;\red229\green218\blue115;}
{\*\expandedcolortbl;;\csgenericrgb\c0\c0\c0;\csgenericrgb\c93333\c93333\c92549;\cssrgb\c14118\c16078\c18039;
\cssrgb\c96471\c97255\c98039;\csgenericrgb\c89804\c85490\c45098;}
\paperw11900\paperh16840\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx566\tx1133\tx1700\tx2267\tx2834\tx3401\tx3968\tx4535\tx5102\tx5669\tx6236\tx6803\pardirnatural\partightenfactor0

\f0\fs24 \cf0 App Description:-\
\
Screen shows weather button to populate weather data of respective city.\
\
Constant class define respective URL and API key required for HTTP request.\
\
Service class define for making HTTP request and get response from request.\
Here HTTP GET request call for getting weather data for specific city.\
\
For making HTTP request and generated JSON response will be done using \'93S
\f1 \cf2 ystem.Net.Http\'94 and\cf3  
\f0 \cf0 \'93
\f1 \cf0 Newtonsoft.Json\'94 packages.\
\
This response JSON data will be parse to Model class.\
\
View model class handle to populate data to UI screen.\
\
\
Weather app URL:- \cf2 \'93http://api.wunderground.com/api/+\{APIKEY\}/conditions/q/CA/
\f2\fs27\fsmilli13600 \cf4 \cb5 \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec4 New_York
\f1\fs24 \cf2 \cb1 \kerning1\expnd0\expndtw0 \outl0\strokewidth0 .json\'94\
\
api key generate form http://api.wunderground.com/\cf6 \uc0\u8232 \cf0 \
\cf3 \uc0\u8232 
\f0 \cf0  }