// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailField_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (AuditTrailSubentityField_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AuditTrailTrivialField_Info))]
  [Serializable]
  public class AuditTrailField_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_DisplayLabel")]
    protected Info _DisplayLabel;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_DefaultLabel")]
    protected Info _DefaultLabel;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_IsList")]
    protected Info _IsList;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_Action")]
    protected Info _Action;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_PackageName")]
    protected Info _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailField_Info_FieldName")]
    protected Info _FieldName;

    public Info DisplayLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLabel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayLabel));
      }
    }

    public Info DefaultLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultLabel));
      }
    }

    public Info IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsList));
      }
    }

    public Info Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Action));
      }
    }

    public Info PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageName));
      }
    }

    public Info FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
