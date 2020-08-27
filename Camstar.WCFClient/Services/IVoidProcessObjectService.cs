// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IVoidProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IVoidProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      VoidProcessObjectMethod[] methods,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result);
  }
}
