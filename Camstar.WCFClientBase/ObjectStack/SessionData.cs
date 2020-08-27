// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SessionData
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SessionData
  {
    [DataMember(EmitDefaultValue = false, Name = "Factory")]
    public string Factory { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "WorkCenter")]
    public string WorkCenter { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Operation")]
    public string Operation { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "DateFormat")]
    public string DateFormat { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "TimeFormat")]
    public string TimeFormat { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "DecimalSeparator")]
    public string DecimalSeparator { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "GroupSeparator")]
    public string GroupSeparator { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserID")]
    public string UserID { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserName")]
    public string UserName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserFullName")]
    public string UserFullName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserDomain")]
    public string UserDomain { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserMenuName")]
    public string UserMenuName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserWebMenuName")]
    public string UserWebMenuName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserPortalMenuName")]
    public string UserPortalMenuName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserPortalMobileMenuName")]
    public string UserPortalMobileMenuName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserPrimaryOrganizationName")]
    public string UserPrimaryOrganizationName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UserPortalProfile")]
    public UserProfileData UserPortalProfile { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Language")]
    public string Language { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "LanguageName")]
    public string LanguageName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Terminology")]
    public string Terminology { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "TerminologyName")]
    public string TerminologyName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ShowLineAssignmentOnLogon")]
    public bool ShowLineAssignmentOnLogon { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "FilterTags")]
    public string FilterTags { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "FilterTagAccess")]
    public string FilterTagAccess { get; set; }
  }
}
