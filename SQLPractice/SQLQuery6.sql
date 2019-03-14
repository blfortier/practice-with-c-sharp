ALTER TABLE DirectMarketing.Opportunity
ADD PRIMARY KEY (OpportunityID),
FOREIGN KEY (ProspectID) REFERENCES ProspectID;
