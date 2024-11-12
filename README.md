ANALYSIS OF WEB API

Authors Blog Post


1. API

localhost:8080/api/author

GET	localhost:8080/api/author  
		responsebody
		[{ 
		"id":  100L,
		"name": "dimitris",
		"email": "aa@gmail.com",
	  }]
GET localhost:8080/api/author/{id}
		responsebody
		{ 
		"id":  100L,
		"name": "dimitris",
		"email": "aa@gmail.com",
	  }

POST localhost:8080/api/author    
	requestbody 
	{ 
	  "name": "dimitris",
	  "email": "aa@gmail.com",
  }
  responsebody
		{ 
		"id":  100L,
		"name": "dimitris",
		"email": "aa@gmail.com",
	  }
  
PUT localhost:8080/api/author/{id}
requestbody 
	{ 
	  "name": "dimitris",
	  "email": "aa@gmail.com",
  }
  responsebody
		{ 
		"id":  100L,
		"name": "dimitris",
		"email": "aa@gmail.com",
	  }


DELETE localhost:8080/api/author/{id}
	responsebody
	true
	
	
-----------------------------------

responsebody
		{ 
			"statusCode": 0,
			"description": "success",
			"value":
			{ 
			"id":  100L,
			"name": "dimitris",
			"email": "aa@gmail.com",
		  }
		}	
		


localhost:8080/api/blog
POST localhost:8080/api/author    
	requestbody 
	{ 
	  "name": "todayblog",
	  "authorid": 32L
  }
  responsebody
		{ 
		"id":  100L,
		"name": "todayblog",
		"authorid": 32L,
		"authorName":"Dimitris"
	  }



-----------------------------------------------------------------

localhost:8080/api/post

POST localhost:8080/api/post    
	requestbody 
	{ 
	  "title": "todayblog",
	  "blogId": 32L
  }
  responsebody
		{ 
		"id":  100L,
		"name": "todayblog",
		"authorid": 32L,
		"authorName":"Dimitris",
		"blogId":32L,
		"blogTitle":"xxx",
	  }