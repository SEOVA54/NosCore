//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Diagnostics.CodeAnalysis;

namespace NosCore.Data.Enumerations.I18N
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum LogLanguageKey
    {
        UNKNOWN,
        DONE,
        PARSE_ALL,
        PARSE_MAPS,
        PARSE_MAPTYPES,
        PARSE_ACCOUNTS,
        PARSE_PORTALS,
        PARSE_TIMESPACES,
        PARSE_ITEMS,
        PARSE_NPCMONSTERS,
        PARSE_NPCMONSTERDATA,
        PARSE_CARDS,
        PARSE_SKILLS,
        PARSE_MAPNPCS,
        PARSE_MONSTERS,
        PARSE_SHOPS,
        PARSE_TELEPORTERS,
        PARSE_SHOPITEMS,
        PARSE_SHOPSKILLS,
        PARSE_RECIPES,
        PARSE_QUESTS,
        I18N_ACTDESC_PARSED,
        I18N_CARD_PARSED,
        I18N_BCARD_PARSED,
        I18N_ITEM_PARSED,
        I18N_MAPIDDATA_PARSED,
        I18N_MAPPOINTDATA_PARSED,
        I18N_MPCMONSTER_PARSED,
        I18N_NPCMONSTERTALK_PARSED,
        I18N_QUEST_PARSED,
        I18N_SKILL_PARSED,
        AUTH_ERROR,
        MASTER_SERVER_PING,
        MASTER_SERVER_PING_FAILED,
        REGISTRED_ON_MASTER,
        AUTHENTICATED_SUCCESS,
        DATABASE_INITIALIZED,
        DATABASE_NOT_UPTODATE,
        CLIENT_DISCONNECTED,
        CHARACTER_NOT_INIT,
        ERROR_CHANGE_MAP,
        AUTH_INCORRECT,
        CLIENT_ARRIVED,
        CORRUPTED_KEEPALIVE,
        INVALID_PASSWORD,
        INVALID_ACCOUNT,
        ACCOUNT_ARRIVED,
        SUCCESSFULLY_LOADED,
        MASTER_SERVER_RETRY,
        ENTER_PATH,
        AT_LEAST_ONE_FILE_MISSING,
        CARDS_PARSED,
        ITEMS_PARSED,
        MAPS_PARSED,
        PORTALS_PARSED,
        MAPS_LOADED,
        NO_MAP,
        MAPMONSTERS_LOADED,
        CORRUPT_PACKET,
        HANDLER_NOT_FOUND,
        PARSE_I18N,
        NPCMONSTERS_PARSED,
        PARSE_DROPS,
        MAPTYPES_PARSED,
        RESPAWNTYPE_PARSED,
        SKILLS_PARSED,
        NPCS_PARSED,
        MONSTERS_PARSED,
        MAPNPCS_LOADED,
        SAVING_ALL,
        ITEMS_LOADED,
        UNKNOWN_PICKERTYPE,
        POCKETTYPE_UNKNOWN,
        NPCMONSTERS_LOADED,
        VISUALTYPE_UNKNOWN,
        UNKNOWN_EQUIPMENTTYPE,
        LANGUAGE_MISSING,
        INVITETYPE_UNKNOWN,
        GROUPREQUESTTYPE_UNKNOWN,
        UNKWNOWN_RECEIVERTYPE,
        NO_SPECIAL_PROPERTIES_WEARABLE,
        CANNOT_TRADE_NOT_TRADABLE_ITEM,
        CANT_USE_ITEM_IN_SHOP,
        TRY_REMOVE_FAILED,
        USE_SP_WITHOUT_SP_ERROR,
        NOT_ENOUGH_GOLD,
        INVALID_EXCHANGE,
        PLAYER_IN_SHOP,
        USER_NOT_IN_EXCHANGE,
        INVALID_EXCHANGE_LIST,
        SHOPS_PARSED,
        SHOPITEMS_PARSED,
        SHOPITEMS_LOADED,
        SHOPS_LOADED,
        CONNECTION_LOST,
        CHANNEL_WILL_EXIT,
        CANT_MOVE_ITEM_IN_SHOP,
        VISUALENTITY_DOES_NOT_EXIST,
        ALREADY_EXCHANGE,
        CANT_FIND_CHARACTER,
        LOADING_MAPINSTANCES,
        PACKET_USED_WITHOUT_CHARACTER,
        AUTH_API_SUCCESS,
        FRIEND_REQUEST_DISCONNECTED,
        SECURITY_TOKEN_UPDATED,
        BAZAAR_DELETE_ERROR,
        BAZAAR_BUY_ERROR,
        BAZAAR_MOD_ERROR,
        DIRECT_ACCESS_OBJECT_DETECTED,
        TRY_OLD_AUTH,
        SHOPSKILLS_LOADED,
        CHUNK_FORMAT_INVALID,
        ITEM_NOT_FOUND,
        QUEST_PRIZES_PARSED,
        QUESTS_PARSED,
        ACTS_PARTS_PARSED,
        SCRIPTS_PARSED,
        PARSE_SCRIPTS,
        QUEST_NOT_FOUND,
        NPCMONSTERSTALKS_LOADED,
        QUESTS_LOADED,
        QUESTOBJECTIVES_LOADED,
        QUESTREWARDS_LOADED,
        SCRIPTS_LOADED,
        NPCTALKS_PARSED,
        WALK_CHECKSUM_INVALID,
        SPEED_INVALID,
        PACKET_USED_WHILE_IN_GAME,
        PACKET_USED_WHILE_NOT_ON_LOGIN,
        CHARACTER_SLOT_EMPTY,
        CHARACTER_SELECTION_FAILED,
        ALREADY_CONNECTED,
        PACKET_HANDLING_ERROR,
        MFA_INCORRECT,
        DATABASE_ERROR,
        SAVE_CHARACTER_FAILED,
        UNBOUND_ITEM_DETECTED,
        MAP_DONT_EXIST,
        CANT_CHANGE_SAME_CLASS,
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum LanguageKey
    {
        SUPPORT,
        CHANNEL,
        ADMINISTRATOR,
        DROP_MAP_FULL,
        BAD_DROP_AMOUNT,
        FRIENDLIST_FULL,
        ALREADY_FRIEND,
        FRIEND_REQUEST_BLOCKED,
        FRIEND_REQUEST_SENT,
        FRIEND_ADDED,
        FRIEND_REJECTED,
        CANT_BLOCK_FRIEND,
        NOT_IN_BLACKLIST,
        BLACKLIST_ADDED,
        BLACKLIST_BLOCKED,
        UNABLE_TO_REQUEST_GROUP,
        USER_NOT_CONNECTED,
        ALREADY_BLACKLISTED,
        USER_IS_NOT_A_FRIEND,
        BANK_FULL,
        ASK_BIND,
        SP_NOPOINTS,
        REPUTATION_CHANGED,
        TOO_RICH_SELLER,
        UPDATE_GOLD,
        LIMIT_EXCEEDED,
        OBJECT_IN_BAZAAR,
        ITEM_GIFTED,
        NOT_IN_FRIENDLIST,
        SPEAKER
    }
}