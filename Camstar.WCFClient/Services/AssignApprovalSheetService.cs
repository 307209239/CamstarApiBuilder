// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignApprovalSheetService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignApprovalSheetService : RouteApprovalSheetBase
  {
    public AssignApprovalSheetService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignApprovalSheetService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).CreateParametricData(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(AssignApprovalSheet assignApprovalSheet)
    {
      return this.CreateParametricData(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.CreateParametricData(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus CreateSheet(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (CreateSheet), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).CreateSheet(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.CreateSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateSheet), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateSheet()
    {
      return this.CreateSheet((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus CreateSheet(AssignApprovalSheet assignApprovalSheet)
    {
      return this.CreateSheet(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus CreateSheet(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.CreateSheet(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetActions(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetActions(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetActions(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetActions(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetActions(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheet(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheet), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetApprovalSheet(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheet), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheet()
    {
      return this.GetApprovalSheet((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheet(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetApprovalSheet(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheet(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetApprovalSheet(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetApprovalSheetDetails(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetApprovalSheetDetails(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetApprovalSheetDetails(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetApprovalSheetTemplate(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetApprovalSheetTemplate(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetDataPoints(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetDataPoints(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetDataPoints(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).GetWIPMsgs(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignApprovalSheet assignApprovalSheet)
    {
      return this.GetWIPMsgs(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetWIPMsgs(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).Load(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus Load(AssignApprovalSheet assignApprovalSheet)
    {
      return this.Load(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus Load(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.Load(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).LoadESigDetails(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(AssignApprovalSheet assignApprovalSheet)
    {
      return this.LoadESigDetails(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.LoadESigDetails(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).ProcessComputation(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(AssignApprovalSheet assignApprovalSheet)
    {
      return this.ProcessComputation(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.ProcessComputation(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).ResolveParametricData(this._UserProfile, assignApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(assignApprovalSheet, AssignApprovalSheetMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignApprovalSheet) null, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(AssignApprovalSheet assignApprovalSheet)
    {
      return this.ResolveParametricData(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.ResolveParametricData(assignApprovalSheet, (AssignApprovalSheet_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus actions = this.GetActions((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.Load((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignApprovalSheet) assignApprovalSheet, (AssignApprovalSheet_Parameters) parameters, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      try
      {
        AssignApprovalSheetMethod[] methods = new AssignApprovalSheetMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignApprovalSheetService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignApprovalSheet cdo,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      try
      {
        return ((IAssignApprovalSheetService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignApprovalSheet) cdo, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.GetEnvironment((AssignApprovalSheet) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignApprovalSheet cdo,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      result = (AssignApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignApprovalSheetService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignApprovalSheetMethod(cdo, AssignApprovalSheetMethods.ExecuteTransaction, (AssignApprovalSheet_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignApprovalSheet) cdo, (AssignApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignApprovalSheet cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignApprovalSheet_Request) null, out AssignApprovalSheet_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result)
    {
      return this.ExecuteTransaction((AssignApprovalSheet) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignApprovalSheet cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignApprovalSheetMethod(cdo, AssignApprovalSheetMethods.AddDataTransaction, (AssignApprovalSheet_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((AssignApprovalSheet) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
