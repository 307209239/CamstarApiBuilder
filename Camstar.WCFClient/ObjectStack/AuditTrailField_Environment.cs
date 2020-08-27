// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailField_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AuditTrailTrivialField_Environment))]
  [KnownType(typeof (AuditTrailSubentityField_Environment))]
  [Serializable]
  public class AuditTrailField_Environment : ServiceData_Environment
  {
    [Metadata("Caption", "", false, false, true, "String", 1050788, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_DisplayLabel")]
    protected Environment _DisplayLabel;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_DefaultLabel")]
    [Metadata("Caption", "", false, false, true, "String", 1050787, false, false, false, null)]
    protected Environment _DefaultLabel;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050847, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_IsList")]
    protected Environment _IsList;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_Action")]
    [Metadata("Generic String", "", false, false, true, "String", 1048937, false, false, false, null)]
    protected Environment _Action;
    [Metadata("Generic String", "", false, false, true, "String", 16777354, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_PackageName")]
    protected Environment _PackageName;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1049129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Environment_FieldName")]
    protected Environment _FieldName;

    public Environment DisplayLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayLabel));
      }
    }

    public Environment DefaultLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultLabel));
      }
    }

    public Environment IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsList));
      }
    }

    public Environment Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Action));
      }
    }

    public Environment PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageName));
      }
    }

    public Environment FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
