@all
Feature: New

Simple calculator for adding two numbers

@allure.owner:JohnDoe
@mytag
Scenario Outline: New two numbers

	Given the first number is <firstNumber>
	And the second number is <secondNumber>
	When the two numbers are added
	Then the result should be <result>

	Examples: 
	| firstNumber | secondNumber | result |
	| 10          | 70           | 80     |
	| 50          | 70           | 120    |	
	| 0          | -70           | -70    |

@allure.owner:JohnDoe
@mytag1
Scenario: New Users

Simple calculator for adding two numbers

	Given I get list of users
	| FirstName | LastName | Email | Phone     | ZipCode |
	| John      | Doe      | a@b.d | 23123-323 | 12345   |
	| Jane      | Boe      | 2@3.d | 000000000 | 11145   |
	| John      | Zoe      | q@1.d | 1111-323 `| 21145   |
	| John      | Qoe      | c@a.d | 333-323 ``| 32345   |
	
