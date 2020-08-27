// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportLogDetail_Info
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
  public class ExportImportLogDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_ObjectName")]
    protected Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_LastUpdateTime")]
    protected Info _LastUpdateTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_CompletionMessage")]
    protected Info _CompletionMessage;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_ObjectRevision")]
    protected Info _ObjectRevision;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Info LastUpdateTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdateTime));
      }
    }

    public Info CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionMessage));
      }
    }

    public Info ObjectRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectRevision));
      }
    }

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
