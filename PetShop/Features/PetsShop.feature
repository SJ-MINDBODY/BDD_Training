Feature:Petshop
In order to create an environment for managing shop
as a user
I want to create , edit, detele, get pet records

Scenario: Find pet  By pet Id
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
When I do get rquest
Then I should get the response as 200


Scenario: find pet By pet invalid Id
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
When I do get rquest
Then I should get the response as 400
And I should get message as 'invalid supllied'

Scenario: Find Pet By non existing ID
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
When I do the Get Request
Then I should get a response as 404
And I should get a message as 'Pet not found'

Scenario: Delete By pet Id
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
And I need to add api_key 'AK888' in the header
When I do delete rquest
Then I should get the response as 200


Scenario: Delete By pet invalid Id
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
And I need to add api_key 'AK888' in the header
When I do delete rquest
Then I should get the response as 400
And I should get message as 'invalid supllied'

Scenario: Delete By pet non existing  Id
Given I have base url 'https://petstore.swagger.io/v2' and resource with petid 'pet/502'
And I need to add api_key 'AK888' in the header
When I do delete rquest
Then I should get the response as 404
And I should get message as 'pet not found '