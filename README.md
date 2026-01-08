# flow-track-app
An attempt at real world application from scratch

# Vision
To learn as much as possible intentionally from this project implementation about e2e aspects of a real-world application.
To become more confident on the performance of my job.
To become more risk-taking and make myself confortable with experimentation.

# Problem statement
FlowTrack is a hybrid work management platform offering both individual and organization-level capabilities. 
The system is designed with explicit tenant isolation, license-aware authorization, customizable and auditability as 
first-class concerns.
FlowTrack focuses on user experience and intuitive design.
We are aiming to keep the architecture future proof.


# Non-goals


# High-level architecture

• User-Tenants-Roles-Policies governed by license.

• Projects have tasks in a hierarchy

• Tasks have various types - Feature, Story, Bug, Spike etc 
	with each mandating some fields and having some hierarchy/relationship with each other

• Tasks have fixed and customizable fields - setting which should be mandatory

• Tasks transition through States (Customizable - create your own workflow, define Done-Done)

• Tasks have the ability to record text, image, code blocks etc

• Some users have special permissions like - 
	• to bulk edit tasks
	• to view tasks across various projects 
	• to create/delete tasks
	• readonly mode for audit purpose
	• primitive querying abilities.


