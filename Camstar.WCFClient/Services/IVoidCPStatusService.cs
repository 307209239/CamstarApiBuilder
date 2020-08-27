// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IVoidCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IVoidCPStatusService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_LoadESigDetails_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Parameters parameters,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      VoidCPStatusMethod[] methods,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      VoidCPStatus voidCPStatus,
      VoidCPStatus_Request request,
      out VoidCPStatus_Result result);
  }
}
