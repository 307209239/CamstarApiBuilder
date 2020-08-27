// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignedMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignedMaintReqMaintService : SubentityMaintenanceBase
  {
    public AssignedMaintReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignedMaintReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).Delete(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Delete(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.Delete(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Delete(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.Delete(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).Freeze(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.Freeze(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.Freeze(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetAssignedMaintenanceReq(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetAssignedMaintenanceReq), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).GetAssignedMaintenanceReq(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.GetAssignedMaintenanceReq, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAssignedMaintenanceReq), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAssignedMaintenanceReq()
    {
      return this.GetAssignedMaintenanceReq((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus GetAssignedMaintenanceReq(
      AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.GetAssignedMaintenanceReq(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus GetAssignedMaintenanceReq(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.GetAssignedMaintenanceReq(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.GetWIPMsgs(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.GetWIPMsgs(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).Load(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Load(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.Load(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus Load(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.Load(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_LoadESigDetails_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.LoadESigDetails, (AssignedMaintReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_LoadESigDetails_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.LoadESigDetails(assignedMaintReqMaint, (AssignedMaintReqMaint_LoadESigDetails_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.LoadESigDetails(assignedMaintReqMaint, (AssignedMaintReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_New_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).New(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.New, (AssignedMaintReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_New_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus New(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.New(assignedMaintReqMaint, (AssignedMaintReqMaint_New_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus New(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.New(assignedMaintReqMaint, (AssignedMaintReqMaint_New_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).NewCopy(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.NewCopy(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.NewCopy(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus ResetResourceUOM(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_ResetResourceUOM_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (ResetResourceUOM), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).ResetResourceUOM(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.ResetResourceUOM, (AssignedMaintReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResetResourceUOM), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResetResourceUOM()
    {
      return this.ResetResourceUOM((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_ResetResourceUOM_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus ResetResourceUOM(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.ResetResourceUOM(assignedMaintReqMaint, (AssignedMaintReqMaint_ResetResourceUOM_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus ResetResourceUOM(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.ResetResourceUOM(assignedMaintReqMaint, (AssignedMaintReqMaint_ResetResourceUOM_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).SaveAs(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.SaveAs(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.SaveAs(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).UnFreeze(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.UnFreeze(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.UnFreeze(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateRefInfoIsUnique(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateRefInfoIsUnique), (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).ValidateRefInfoIsUnique(this._UserProfile, assignedMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(assignedMaintReqMaint, AssignedMaintReqMaintMethods.ValidateRefInfoIsUnique, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateRefInfoIsUnique), res, (DCObject) assignedMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateRefInfoIsUnique()
    {
      return this.ValidateRefInfoIsUnique((AssignedMaintReqMaint) null, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus ValidateRefInfoIsUnique(
      AssignedMaintReqMaint assignedMaintReqMaint)
    {
      return this.ValidateRefInfoIsUnique(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus ValidateRefInfoIsUnique(
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.ValidateRefInfoIsUnique(assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_LoadESigDetails_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.New((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_New_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignedMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignedMaintReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignedMaintReqMaint) assignedMaintReqMaint, (AssignedMaintReqMaint_Parameters) parameters, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      try
      {
        AssignedMaintReqMaintMethod[] methods = new AssignedMaintReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignedMaintReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignedMaintReqMaint cdo,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      try
      {
        return ((IAssignedMaintReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AssignedMaintReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignedMaintReqMaint) cdo, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.GetEnvironment((AssignedMaintReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignedMaintReqMaint cdo,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      result = (AssignedMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignedMaintReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignedMaintReqMaintMethod(cdo, AssignedMaintReqMaintMethods.ExecuteTransaction, (AssignedMaintReqMaint_Parameters) null));
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
        AssignedMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignedMaintReqMaint) cdo, (AssignedMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignedMaintReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignedMaintReqMaint_Request) null, out AssignedMaintReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result)
    {
      return this.ExecuteTransaction((AssignedMaintReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignedMaintReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignedMaintReqMaintMethod(cdo, AssignedMaintReqMaintMethods.AddDataTransaction, (AssignedMaintReqMaint_Parameters) null));
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
        return this.AddDataTransaction((AssignedMaintReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
