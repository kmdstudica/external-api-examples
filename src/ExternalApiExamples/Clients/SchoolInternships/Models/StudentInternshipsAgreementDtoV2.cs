// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentInternshipsAgreementDtoV2
    /// </summary>
    /// <remarks>
    /// A student's agreement for school based internship
    /// </remarks>
    public partial class StudentInternshipsAgreementDtoV2
    {
        /// <summary>
        /// Initializes a new instance of the StudentInternshipsAgreementDtoV2
        /// class.
        /// </summary>
        public StudentInternshipsAgreementDtoV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentInternshipsAgreementDtoV2
        /// class.
        /// </summary>
        /// <param name="agreementId">Guid</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="agreementType">ApprenticeshipAgreementType</param>
        /// <param name="schoolCode">String</param>
        /// <param name="comment">String</param>
        /// <param name="companyName">String</param>
        /// <param name="companyAddress">String</param>
        /// <param name="companyCountryCode">String</param>
        /// <param name="cvrNumber">String</param>
        /// <param name="pNumber">String</param>
        /// <param name="seNumber">String</param>
        /// <param name="causeOfCompletion">Possible values include:
        /// 'Terminated', 'Finished', 'StudentDeceased', 'FinishedNotSkilled',
        /// 'FinishedSkilled', 'PresumedTerminated',
        /// 'RepealedAfterTrialPeriodByMutualAgreement',
        /// 'RepealedAfterTrialPeriodByStudent',
        /// 'RepealedAfterTrialPeriodByCompany',
        /// 'RepealedAfterTrialPeriodTerminatingPartyUnknown',
        /// 'RepealedDuringTrial', 'CompetenceAssessmentCompleted',
        /// 'RepealedByProfessionalCommittee', 'TerminatedDueToOtherReason',
        /// 'TerminatedDueToOtherEducation', 'TerminatedDueToPaidWork',
        /// 'AgreementFulfilled', 'LeaveOfAbsenceForInternshipAbroad',
        /// 'PersonEvaluatedNotEmmaAfterStart', 'RepealedBeforeStart'</param>
        /// <param name="educationalAgreementType">Possible values include:
        /// 'SubagreementInCombinationagreement',
        /// 'SubagreementInPreparationforBasiceducationEud',
        /// 'SubagreementInSchoolinternship', 'ShortAgreement',
        /// 'OrdinaryAgreement', 'RemainingAgreement'</param>
        /// <param name="agreementSchoolInstitutionNumber">String</param>
        /// <param name="agreementDepartmentInstitutionNumber">String</param>
        /// <param
        /// name="laidOutInternshipCenterInstitutionNumber">String</param>
        /// <param
        /// name="laidOutInternshipCenterDepartmentInstitutionNumber">String</param>
        public StudentInternshipsAgreementDtoV2(System.Guid agreementId, System.DateTime startDate, System.DateTime endDate, string agreementType, string schoolCode = default(string), System.Guid? apprenticeshipEducationalProgrammeId = default(System.Guid?), string comment = default(string), System.Guid? schoolInternshipAgreementId = default(System.Guid?), System.Guid? fguEudProgrammeAgreementId = default(System.Guid?), string companyName = default(string), string companyAddress = default(string), string companyCountryCode = default(string), System.DateTime? signedDate = default(System.DateTime?), System.DateTime? receivedDate = default(System.DateTime?), System.DateTime? completedRegistrationDate = default(System.DateTime?), System.DateTime? creditPreApprovedDate = default(System.DateTime?), System.DateTime? creditFinalApprovedDate = default(System.DateTime?), string cvrNumber = default(string), string pNumber = default(string), string seNumber = default(string), string causeOfCompletion = default(string), System.Guid? combinationAgreementId = default(System.Guid?), string educationalAgreementType = default(string), IList<string> supplementAgreementInformation = default(IList<string>), string agreementSchoolInstitutionNumber = default(string), string agreementDepartmentInstitutionNumber = default(string), string laidOutInternshipCenterInstitutionNumber = default(string), string laidOutInternshipCenterDepartmentInstitutionNumber = default(string))
        {
            AgreementId = agreementId;
            SchoolCode = schoolCode;
            ApprenticeshipEducationalProgrammeId = apprenticeshipEducationalProgrammeId;
            StartDate = startDate;
            EndDate = endDate;
            Comment = comment;
            AgreementType = agreementType;
            SchoolInternshipAgreementId = schoolInternshipAgreementId;
            FguEudProgrammeAgreementId = fguEudProgrammeAgreementId;
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            CompanyCountryCode = companyCountryCode;
            SignedDate = signedDate;
            ReceivedDate = receivedDate;
            CompletedRegistrationDate = completedRegistrationDate;
            CreditPreApprovedDate = creditPreApprovedDate;
            CreditFinalApprovedDate = creditFinalApprovedDate;
            CvrNumber = cvrNumber;
            PNumber = pNumber;
            SeNumber = seNumber;
            CauseOfCompletion = causeOfCompletion;
            CombinationAgreementId = combinationAgreementId;
            EducationalAgreementType = educationalAgreementType;
            SupplementAgreementInformation = supplementAgreementInformation;
            AgreementSchoolInstitutionNumber = agreementSchoolInstitutionNumber;
            AgreementDepartmentInstitutionNumber = agreementDepartmentInstitutionNumber;
            LaidOutInternshipCenterInstitutionNumber = laidOutInternshipCenterInstitutionNumber;
            LaidOutInternshipCenterDepartmentInstitutionNumber = laidOutInternshipCenterDepartmentInstitutionNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        [JsonProperty(PropertyName = "agreementId")]
        public System.Guid AgreementId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "schoolCode")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apprenticeshipEducationalProgrammeId")]
        public System.Guid? ApprenticeshipEducationalProgrammeId { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets apprenticeshipAgreementType
        /// </summary>
        /// <remarks>
        /// Possible values include: 'EducationalAgreement',
        /// 'CombinationAgreement', 'SchoolInternshipAgreement',
        /// 'InternshipAbroadAgreement', 'FguEudProgrammeAgreement',
        /// 'CompanyPlacedInternshipAgreement',
        /// 'CompanyPlacedInternshipAbroadAgreement', 'Breaks'
        /// </remarks>
        [JsonProperty(PropertyName = "agreementType")]
        public string AgreementType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schoolInternshipAgreementId")]
        public System.Guid? SchoolInternshipAgreementId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fguEudProgrammeAgreementId")]
        public System.Guid? FguEudProgrammeAgreementId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "companyAddress")]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "companyCountryCode")]
        public string CompanyCountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "signedDate")]
        public System.DateTime? SignedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "receivedDate")]
        public System.DateTime? ReceivedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "completedRegistrationDate")]
        public System.DateTime? CompletedRegistrationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "creditPreApprovedDate")]
        public System.DateTime? CreditPreApprovedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "creditFinalApprovedDate")]
        public System.DateTime? CreditFinalApprovedDate { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "cvrNumber")]
        public string CvrNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "pNumber")]
        public string PNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "seNumber")]
        public string SeNumber { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Terminated', 'Finished',
        /// 'StudentDeceased', 'FinishedNotSkilled', 'FinishedSkilled',
        /// 'PresumedTerminated', 'RepealedAfterTrialPeriodByMutualAgreement',
        /// 'RepealedAfterTrialPeriodByStudent',
        /// 'RepealedAfterTrialPeriodByCompany',
        /// 'RepealedAfterTrialPeriodTerminatingPartyUnknown',
        /// 'RepealedDuringTrial', 'CompetenceAssessmentCompleted',
        /// 'RepealedByProfessionalCommittee', 'TerminatedDueToOtherReason',
        /// 'TerminatedDueToOtherEducation', 'TerminatedDueToPaidWork',
        /// 'AgreementFulfilled', 'LeaveOfAbsenceForInternshipAbroad',
        /// 'PersonEvaluatedNotEmmaAfterStart', 'RepealedBeforeStart'
        /// </summary>
        [JsonProperty(PropertyName = "causeOfCompletion")]
        public string CauseOfCompletion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "combinationAgreementId")]
        public System.Guid? CombinationAgreementId { get; set; }

        /// <summary>
        /// Gets or sets possible values include:
        /// 'SubagreementInCombinationagreement',
        /// 'SubagreementInPreparationforBasiceducationEud',
        /// 'SubagreementInSchoolinternship', 'ShortAgreement',
        /// 'OrdinaryAgreement', 'RemainingAgreement'
        /// </summary>
        [JsonProperty(PropertyName = "educationalAgreementType")]
        public string EducationalAgreementType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplementAgreementInformation")]
        public IList<string> SupplementAgreementInformation { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "agreementSchoolInstitutionNumber")]
        public string AgreementSchoolInstitutionNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "agreementDepartmentInstitutionNumber")]
        public string AgreementDepartmentInstitutionNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "laidOutInternshipCenterInstitutionNumber")]
        public string LaidOutInternshipCenterInstitutionNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        [JsonProperty(PropertyName = "laidOutInternshipCenterDepartmentInstitutionNumber")]
        public string LaidOutInternshipCenterDepartmentInstitutionNumber { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AgreementType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AgreementType");
            }
        }
    }
}
