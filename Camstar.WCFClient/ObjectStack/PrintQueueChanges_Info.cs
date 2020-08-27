// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintQueueChanges_Info
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
  public class PrintQueueChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_PrintFile")]
    protected Info _PrintFile;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_EncodingType")]
    protected Info _EncodingType;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_OutputToFile")]
    protected Info _OutputToFile;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Info_Description")]
    protected new Info _Description;

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info PrintFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintFile));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info EncodingType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EncodingType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EncodingType));
      }
    }

    public Info OutputToFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutputToFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OutputToFile));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
