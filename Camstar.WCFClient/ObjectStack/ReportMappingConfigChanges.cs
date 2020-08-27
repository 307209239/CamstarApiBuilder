// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportMappingConfigChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ReportMappingConfigChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_ReportMappingConfigFile")]
    protected Primitive<string> _ReportMappingConfigFile;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_ReportTemplate")]
    protected Primitive<string> _ReportTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ReportMappingConfigChanges && object.Equals((object) this._ReportMappingConfigFile, (object) ((ReportMappingConfigChanges) obj)._ReportMappingConfigFile) && (object.Equals((object) this._ReportTemplate, (object) ((ReportMappingConfigChanges) obj)._ReportTemplate) && object.Equals((object) this._ObjectToChange, (object) ((ReportMappingConfigChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((ReportMappingConfigChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string> ReportMappingConfigFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportMappingConfigFile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportMappingConfigFile));
      }
    }

    public Primitive<string> ReportTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTemplate), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportTemplate));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
