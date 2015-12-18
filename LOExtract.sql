SELECT 
  dbo.UnitLearningOutcome.LearningOutsomeName,
  dbo.LOTopic.idLOTopic,
  dbo.LOTopic.TopicCode,
  dbo.LOTopic.TopicName
FROM
  dbo.UnitLearningOutcome
  INNER JOIN dbo.QualUnit ON (dbo.UnitLearningOutcome.QualUnit_idQualUnit = dbo.QualUnit.idQualUnit)
  INNER JOIN dbo.CourseUnit ON (dbo.QualUnit.idQualUnit = dbo.CourseUnit.QualUnit_idQualUnit)
  INNER JOIN dbo.LOTopic ON (dbo.UnitLearningOutcome.idUnitLearningOutcome = dbo.LOTopic.UnitLearningOutcome_idUnitLearningOutcome)
WHERE
  dbo.CourseUnit.idCourseUnit = 1 AND 
  dbo.LOTopic.TopicTestingMethod_idTopicTestingMethod = 3