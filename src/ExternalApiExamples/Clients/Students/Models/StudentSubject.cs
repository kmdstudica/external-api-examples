// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Student_Subject
    /// </summary>
    /// <remarks>
    /// Description of a subject object for which a mark is given
    /// </remarks>
    public partial class StudentSubject
    {
        /// <summary>
        /// Initializes a new instance of the StudentSubject class.
        /// </summary>
        public StudentSubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentSubject class.
        /// </summary>
        /// <param name="subjectDesignation">String</param>
        /// <param name="subjectNumber">String</param>
        /// <param name="levelDesignation">String</param>
        /// <param name="levelRankOrder">Int32</param>
        /// <param name="subjectCategory">String</param>
        /// <param name="subjectCategoryDesignation">String</param>
        /// <param name="evaluationForm">String</param>
        /// <param name="evaluationFormDesignation">String</param>
        /// <param name="markScaleDesignation">String</param>
        public StudentSubject(string subjectDesignation, string subjectNumber, string levelDesignation, int levelRankOrder, string subjectCategory = default(string), string subjectCategoryDesignation = default(string), string evaluationForm = default(string), string evaluationFormDesignation = default(string), string markScaleDesignation = default(string))
        {
            SubjectDesignation = subjectDesignation;
            SubjectNumber = subjectNumber;
            SubjectCategory = subjectCategory;
            SubjectCategoryDesignation = subjectCategoryDesignation;
            EvaluationForm = evaluationForm;
            EvaluationFormDesignation = evaluationFormDesignation;
            MarkScaleDesignation = markScaleDesignation;
            LevelDesignation = levelDesignation;
            LevelRankOrder = levelRankOrder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The designation/description of the subject the mark is given in
        /// </remarks>
        [JsonProperty(PropertyName = "subjectDesignation")]
        public string SubjectDesignation { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The numeric ID of the subject the mark is given in
        /// </remarks>
        [JsonProperty(PropertyName = "subjectNumber")]
        public string SubjectNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The identification of the subject category that the subject belongs
        /// to
        /// </remarks>
        [JsonProperty(PropertyName = "subjectCategory")]
        public string SubjectCategory { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The name of the subject category that the subject belongs to
        /// </remarks>
        [JsonProperty(PropertyName = "subjectCategoryDesignation")]
        public string SubjectCategoryDesignation { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Subject evaluation form code, e.g. MDT for Oral
        /// </remarks>
        [JsonProperty(PropertyName = "evaluationForm")]
        public string EvaluationForm { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Subject evaluation form description, e.g. Mundtlig evaluering
        /// </remarks>
        [JsonProperty(PropertyName = "evaluationFormDesignation")]
        public string EvaluationFormDesignation { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Scale type for the mark given to the student, e.g. 7-trinsskala
        /// </remarks>
        [JsonProperty(PropertyName = "markScaleDesignation")]
        public string MarkScaleDesignation { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The designation/description of the level of the subject the mark is
        /// given in, e.g. Avanceret
        /// </remarks>
        [JsonProperty(PropertyName = "levelDesignation")]
        public string LevelDesignation { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// The order of level
        /// </remarks>
        [JsonProperty(PropertyName = "levelRankOrder")]
        public int LevelRankOrder { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubjectDesignation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubjectDesignation");
            }
            if (SubjectNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubjectNumber");
            }
            if (LevelDesignation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LevelDesignation");
            }
            if (SubjectDesignation != null)
            {
                if (SubjectDesignation.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SubjectDesignation", 1);
                }
            }
            if (SubjectNumber != null)
            {
                if (SubjectNumber.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SubjectNumber", 1);
                }
            }
            if (LevelDesignation != null)
            {
                if (LevelDesignation.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "LevelDesignation", 1);
                }
            }
        }
    }
}
