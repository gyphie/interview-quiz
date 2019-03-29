# Gather a form

Create a web form; gather the following information:
<ul>
	<li>Full Name</li>
	<li>Position/Title</li>
	<li>Manager's Name</li>
	<li>Company Name</li>
	<li>Phone Number</li>
	<li>Salary</li>
	<li>Currently Employeed</li>
</ul>

Provide a "Process Info" button that when clicked completes the following:

<ol>
	<li>Store the data in a JavaScript object.</li>
	<li>Redisplay the data in a business card style block</li>
	<li>Display a table of adjusted salary values for different regions:
		<ul>
			<li>Base: original salary</li>
			<li>West Coast: salary * 0.6</li>
			<li>Mid West: salary * 1.2</li>
			<li>East Coast: salary * 0.8</li>
		</ul>
	</li>
</ol>

If the form data is changed allow the "Process Info" button to be clicked again to update the page.

Provide simple validation on the salary field. The field should be a positive number above 10000.
It should also accept the [$,.] characters so values like $15,512.13 are accepted.