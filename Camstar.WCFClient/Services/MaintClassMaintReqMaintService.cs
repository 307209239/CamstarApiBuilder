// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintClassMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintClassMaintReqMaintService : AssignedMaintReqMaintBase
  {
    public MaintClassMaintReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintClassMaintReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).Delete(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Delete(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.Delete(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Delete(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.Delete(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).Freeze(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.Freeze(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.Freeze(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.GetWIPMsgs(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.GetWIPMsgs(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).Load(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Load(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.Load(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus Load(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.Load(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_LoadESigDetails_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.LoadESigDetails, (MaintClassMaintReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_LoadESigDetails_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.LoadESigDetails(maintClassMaintReqMaint, (MaintClassMaintReqMaint_LoadESigDetails_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.LoadESigDetails(maintClassMaintReqMaint, (MaintClassMaintReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).New(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus New(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.New(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus New(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.New(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).NewCopy(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.NewCopy(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.NewCopy(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).SaveAs(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.SaveAs(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.SaveAs(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Parameters parameters,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).UnFreeze(this._UserProfile, maintClassMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(maintClassMaintReqMaint, MaintClassMaintReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) maintClassMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MaintClassMaintReqMaint) null, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(MaintClassMaintReqMaint maintClassMaintReqMaint)
    {
      return this.UnFreeze(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MaintClassMaintReqMaint maintClassMaintReqMaint,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.UnFreeze(maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_LoadESigDetails_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.New((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintClassMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintClassMaintReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintClassMaintReqMaint) maintClassMaintReqMaint, (MaintClassMaintReqMaint_Parameters) parameters, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      try
      {
        MaintClassMaintReqMaintMethod[] methods = new MaintClassMaintReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintClassMaintReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintClassMaintReqMaint cdo,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      try
      {
        return ((IMaintClassMaintReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintClassMaintReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintClassMaintReqMaint) cdo, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.GetEnvironment((MaintClassMaintReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintClassMaintReqMaint cdo,
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      result = (MaintClassMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintClassMaintReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(cdo, MaintClassMaintReqMaintMethods.ExecuteTransaction, (MaintClassMaintReqMaint_Parameters) null));
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
        MaintClassMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintClassMaintReqMaint) cdo, (MaintClassMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintClassMaintReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintClassMaintReqMaint_Request) null, out MaintClassMaintReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintClassMaintReqMaint_Request request,
      out MaintClassMaintReqMaint_Result result)
    {
      return this.ExecuteTransaction((MaintClassMaintReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintClassMaintReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintClassMaintReqMaintMethod(cdo, MaintClassMaintReqMaintMethods.AddDataTransaction, (MaintClassMaintReqMaint_Parameters) null));
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
        return this.AddDataTransaction((MaintClassMaintReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
