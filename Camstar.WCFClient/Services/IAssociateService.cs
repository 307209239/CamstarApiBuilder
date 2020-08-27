// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssociateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssociateService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Associate associate,
      Associate_LoadESigDetails_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus Validate_OneChildContainer(
      UserProfile userProfile,
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssociateMethod[] methods,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Associate associate,
      Associate_Request request,
      out Associate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Associate associate,
      Associate_Request request,
      out Associate_Result result);
  }
}
