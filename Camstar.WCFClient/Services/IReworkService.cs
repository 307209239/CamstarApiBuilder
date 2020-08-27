// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReworkService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReworkService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Rework rework,
      Rework_LoadESigDetails_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus ValidateReworkReason(
      UserProfile userProfile,
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReworkMethod[] methods,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Rework rework,
      Rework_Request request,
      out Rework_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Rework rework,
      Rework_Request request,
      out Rework_Result result);
  }
}
