Feature: LoremIpsumFeature
	Test main functionality of www.lipsum.com

Scenario Outline: Check homepage first paragraph right word contain 
	Given User clicks switch language to '<language>' button
	Then User checks first paragraph contains '<word>'
	Examples: 
	| language | word   |
	| uk       | риба   |
	| en       | dummy  |
	| pl       | latach |
	
Scenario Outline: Check default start sentence of generated text
	Given User clicks on 'Generate' button
	Then User checks first paragraph start with default sentence

Scenario Outline: Check correct generated amount of items
	Given User clicks on '<item>' radiobutton
	When User makes input is <input>
	Given User clicks on 'Generate' button
	Then User checks generated info displays correctly amount of '<item>'
	Examples: 
	| input | item       |
	| 10    | words      |
	| -1    | words      |
	| 0     | words      |
	| 5     | words      |
	| 20    | words      |
	| 10    | bytes      |
	| -1    | bytes      |
	| 0     | bytes      |
	| 5     | bytes      |
	| 20    | bytes      |
	| 10    | lists      |
	| -1    | lists      |
	| 0     | lists      |
	| 5     | lists      |
	| 20    | lists      |
	| 10    | paragraphs |
	| -1    | paragraphs |
	| 0     | paragraphs |
	| 5     | paragraphs |
	| 20    | paragraphs |
	

Scenario Outline: Check correct checkbox work
	Given User clicks on checkbox
	And User clicks on 'Generate' button
	Then User checks first paragraph doesn't start with default sentence

Scenario Outline: Check correct avarage of paragraphs, what include certain word
	Given User clicks on 'Generate' button
	And User checks amount of paragraphs contains word '<word>'
	And User clicks on 'HomePage' button
	When User repeat from one to third steps <numberOfGenerations> times with check word '<word>'
	Then User checks correct avarage of paragraps with <numberOfGenerations> generations
	Examples: 
	| numberOfGenerations | word  |
	| 10		      | lorem |
