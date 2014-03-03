create table Train
(
train_id		int not null auto_increment,
train_type		varchar(50),
model			varchar(50),
numCars			int,
weight			float,
maxWeight		float,
maxNumCars		int,
maxVelocity		float,
maxAcceleration	float,



primary key(train_id)
);



create table formulaConstants
(

MPH_TO_FPS		float,
FPS_TO_MPH		float,
overspeed		int,
RTMax			float,
correctionFactor float,
BREFFMPH		float,
safetyFactor	float,
overhang		int
);


create table trackSegment
(
segment_id		int not null auto_increment,
segmentNumber	varchar(10),
grade			float,
direction		varchar(20),
startLocation	float,
endLocation		float,
distanceMPH		float,
distanceKMH		float,
velThroughBlock	int,

primary key(segment_id)
);


create table weightedGradient
(
grade_id		int not null auto_increment,
gradeFrom		int,
gradeTo			int,
distance		int,
grade			float,

primary key (grade_id)
);



create table Track
(
track_id		int not null auto_increment,
trackName		varchar(50),
direction		varchar(20),
avgGrade		float,
maxSpeed		float,
startLocation	float,
endLocation		float,
distance		float,
units			varchar(20),


primary key(track_id)
);

