// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignmentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignmentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignmentMethod[] methods,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result);
  }
}
