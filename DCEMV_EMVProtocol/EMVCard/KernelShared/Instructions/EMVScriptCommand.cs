/*
*************************************************************************
DC EMV
Open Source EMV
Copyright (C) 2018  Vicente Da Silva

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see http://www.gnu.org/licenses/
*************************************************************************
*/
using DCEMV.Shared;
using DCEMV.TLVProtocol;

namespace DCEMV.EMVProtocol
{
    public class EMVScriptCommandRequest : EMVCommand
    {
        public EMVScriptCommandRequest() //init with default values, these will be replaced when request created via deserialize
            : base(ISO7816Protocol.Cla.CompliantCmd0x, EMVInstructionEnum.GetResponse, null, 0x00, 0x00)
        {
            ApduResponseType = typeof(EMVScriptCommandResponse);
        }

        public override void Deserialize(byte[] input)
        {
            base.Deserialize(input);
            Logger.Log(ToPrintString());
        }
        
    }

    public class EMVScriptCommandResponse : EMVResponse
    {
        protected override TLV GetTLVResponse()
        {
            return null;
        }

        public override void Deserialize(byte[] response)
        {
            base.Deserialize(response);
            Logger.Log(ToPrintString());
        }
    }
}
