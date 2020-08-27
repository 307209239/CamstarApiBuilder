// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.SessionData
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class SessionData
  {
    [DataMember(EmitDefaultValue = false)]
    public string Factory;
    [DataMember(EmitDefaultValue = false)]
    public string WorkCenter;
    [DataMember(EmitDefaultValue = false)]
    public string Operation;
    [DataMember(EmitDefaultValue = false)]
    public string DateFormat;
    [DataMember(EmitDefaultValue = false)]
    public string TimeFormat;
    [DataMember(EmitDefaultValue = false)]
    public string DecimalSeparator;
    [DataMember(EmitDefaultValue = false)]
    public string GroupSeparator;
    [DataMember(EmitDefaultValue = false)]
    public string UserID;
    [DataMember(EmitDefaultValue = false)]
    public string UserName;
    [DataMember(EmitDefaultValue = false)]
    public string UserFullName;
    [DataMember(EmitDefaultValue = false)]
    public string UserDomain;
    [DataMember(EmitDefaultValue = false)]
    public string UserMenuName;
    [DataMember(EmitDefaultValue = false)]
    public string UserWebMenuName;
    [DataMember(EmitDefaultValue = false)]
    public string UserPortalMenuName;
    [DataMember(EmitDefaultValue = false)]
    public string UserPortalMobileMenuName;
    [DataMember(EmitDefaultValue = false)]
    public string UserPrimaryOrganizationName;
    [DataMember(EmitDefaultValue = false)]
    public UserProfileData UserPortalProfile;
    [DataMember(EmitDefaultValue = false)]
    public string Language;
    [DataMember(EmitDefaultValue = false)]
    public string LanguageName;
    [DataMember(EmitDefaultValue = false)]
    public string Terminology;
    [DataMember(EmitDefaultValue = false)]
    public string TerminologyName;
    [DataMember(EmitDefaultValue = false)]
    public bool ShowLineAssignmentOnLogon;
    [DataMember(EmitDefaultValue = false)]
    public string FilterTags;
    [DataMember(EmitDefaultValue = false)]
    public string FilterTagAccess;
  }
}
