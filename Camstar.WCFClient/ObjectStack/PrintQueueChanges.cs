// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintQueueChanges
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
  public class PrintQueueChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_PrintQueue")]
    protected Primitive<string> _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_PrintFile")]
    protected Primitive<string> _PrintFile;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_EncodingType")]
    protected Enumeration<EncodingTypeEnum, int> _EncodingType;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_OutputToFile")]
    protected Primitive<bool> _OutputToFile;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Description")]
    protected new Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is PrintQueueChanges && object.Equals((object) this._PrintQueue, (object) ((PrintQueueChanges) obj)._PrintQueue) && (object.Equals((object) this._PrintFile, (object) ((PrintQueueChanges) obj)._PrintFile) && object.Equals((object) this._ObjectToChange, (object) ((PrintQueueChanges) obj)._ObjectToChange)) && (object.Equals((object) this._EncodingType, (object) ((PrintQueueChanges) obj)._EncodingType) && object.Equals((object) this._OutputToFile, (object) ((PrintQueueChanges) obj)._OutputToFile) && (object.Equals((object) this._Name, (object) ((PrintQueueChanges) obj)._Name) && object.Equals((object) this._Description, (object) ((PrintQueueChanges) obj)._Description))) && base.Equals(obj);
    }

    public Primitive<string> PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Primitive<string> PrintFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintFile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PrintFile));
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

    public Enumeration<EncodingTypeEnum, int> EncodingType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EncodingType), (object) value);
      }
      get
      {
        return (Enumeration<EncodingTypeEnum, int>) this.PropertyGet(nameof (EncodingType));
      }
    }

    public Primitive<bool> OutputToFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutputToFile), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OutputToFile));
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

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
